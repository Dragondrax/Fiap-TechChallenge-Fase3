using Docker.DotNet;
using Docker.DotNet.Models;
using Fiap.TechChallenge.Fase1.Data.Context;
using Fiap.TechChallenge.Fase1.IoC;
using Fiap.TechChallenge.Fase1.SharedKernel.RabbitMQ;
using Fiap.TechChallenge.Fase3.Contato.Consumers;
using Fiap.TechChallenge.Fase3.Contato.Services;
using Fiap.TechChallenge.Fase3.Persistencia.Services;
using Fiap.TechChallenge.Fase3.RabbitMQ.GerenciamentoFilas;
using Fiap.TechChallenge.Fase3.Usuario.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Npgsql;

namespace Fiap.TechChallenge.Fase1.Integration.Tests.Infra
{
    public class DockerFixture : IDisposable
    {
        private string _containerId;
        private readonly string _environment;
        private readonly string containerName = "postgres-fiap-integracao";
        private readonly string containerNameRabbitMQ = "rabbitmq-fiap-integracao";
        private readonly string networkName = "fiap-network";
        private readonly DockerClient _dockerClient = new DockerClientConfiguration().CreateClient();
        private readonly IConfiguracoesRabbitMQ _configuracaoRabbit = new ConfiguracoesRabbitMQ();
        private readonly IGerenciamentoFilasRabbitMQ _gerenciamentoFila = new GerenciamentoFilasRabbitMQ();
        public readonly IHost _hostContato;
        public readonly IHost _hostUsuario;
        public readonly IHost _hostPersistencia;

        public DockerFixture()
        {
            var existingContainer = _dockerClient.Containers.ListContainersAsync(new ContainersListParameters { All = true }).GetAwaiter().GetResult()
                                                            .FirstOrDefault(c => c.Names.Contains($"/{containerName}"));

            if (existingContainer != null)
            {
                _containerId = existingContainer.ID;
                if (existingContainer.State != "running")
                {
                    _dockerClient.Containers.StartContainerAsync(_containerId, new ContainerStartParameters()).GetAwaiter().GetResult();
                }
            }
            else
            {
                var networks = _dockerClient.Networks.ListNetworksAsync(new NetworksListParameters());
                var existeNetwork = networks.Result.Any(n => n.Name == networkName);

                if (!existeNetwork)
                {
                    var networkCreateResponse = _dockerClient.Networks.CreateNetworkAsync(new NetworksCreateParameters
                    {
                        Name = networkName,
                        Driver = "bridge"
                    }).GetAwaiter().GetResult();

                    var networkId = networkCreateResponse.ID;
                }

                //Postgres
                var createContainerResponse = _dockerClient.Containers.CreateContainerAsync(new CreateContainerParameters
                {
                    Name = containerName,
                    Image = "postgres:latest",
                    Env = new List<string> { "POSTGRES_DB=techchallenge", "POSTGRES_USER=postgres", "POSTGRES_PASSWORD=102030" },
                    HostConfig = new HostConfig
                    {
                        PortBindings = new Dictionary<string, IList<PortBinding>>()
                        {
                            { "5432/tcp", new List<PortBinding> { new PortBinding { HostPort = "5432" } } }
                        },
                        PublishAllPorts = true
                    },
                    NetworkingConfig = new NetworkingConfig
                    {
                        EndpointsConfig = new Dictionary<string, EndpointSettings>
                        {
                            { networkName, new EndpointSettings() }
                        }
                    }
                }).GetAwaiter().GetResult();

                _containerId = createContainerResponse.ID;

                _dockerClient.Containers.StartContainerAsync(_containerId, new ContainerStartParameters()).GetAwaiter().GetResult();

                var options = new DbContextOptionsBuilder<ContextTechChallenge>()
                    .UseNpgsql(GetConnectionString())
                    .Options;

                using (var context = new ContextTechChallenge(options))
                {
                    if (AguardarContainerPostgresEstarProntoParaConexao().GetAwaiter().GetResult())
                        context.Database.MigrateAsync().GetAwaiter();
                    else
                        throw new Exception("Nao foi possivel gerar uma conexao com o postgres");
                }

                //RabbitMQ
                createContainerResponse = _dockerClient.Containers.CreateContainerAsync(new CreateContainerParameters
                {
                    Name = containerNameRabbitMQ,
                    Image = "rabbitmq:3-management",
                    Env = new List<string> { "RABBITMQ_DEFAULT_USER=techchallenge", "RABBITMQ_DEFAULT_PASS=techchallenge", "RABBITMQ_ERLANG_COOKIE=techchallenge" },
                    HostConfig = new HostConfig
                    {
                        PortBindings = new Dictionary<string, IList<PortBinding>>()
                        {
                            { "5672/tcp", new List<PortBinding> { new PortBinding { HostPort = "5672" } } }, // Porta padrão do RabbitMQ
                            { "15672/tcp", new List<PortBinding> { new PortBinding { HostPort = "15672" } } } // Porta da interface de gerenciamento
                        },
                        PublishAllPorts = true
                    },
                    NetworkingConfig = new NetworkingConfig
                    {
                        EndpointsConfig = new Dictionary<string, EndpointSettings>
                        {
                            { networkName, new EndpointSettings() }
                        }
                    }
                }).GetAwaiter().GetResult();

                _containerId = createContainerResponse.ID;

                _dockerClient.Containers.StartContainerAsync(_containerId, new ContainerStartParameters()).GetAwaiter().GetResult();

                //Testa a conexão e cria as filas
                AguardarContainerRabbitMQEstarProntoParaConexao(_dockerClient).GetAwaiter().GetResult();

            }

            _hostPersistencia = Host.CreateDefaultBuilder()
                       .ConfigureServices((context, services) =>
                       {
                           services.AddHostedService<Fiap.TechChallenge.Fase3.Persistencia.Worker>();

                           InjecaoDependenciaWorkers.ResolverDependencia(services);

                           services.AddSingleton<IPersistirContatoRepository, PersistirContatoRepository>();
                           services.AddSingleton<IPersistirUsuarioRepository, PersistirUsuarioRepository>();
                           services.AddSingleton<IConsumers, Consumers>();

                           services.AddDbContext<ContextTechChallenge>(options =>
                           {
                               var configuration = context.Configuration;
                               options.UseNpgsql(configuration.GetConnectionString("conexao"), x => x.MigrationsAssembly("Fiap.TechChallenge.Fase1.Data")).UseLowerCaseNamingConvention();
                           }, ServiceLifetime.Singleton);
                       })
                       .Build();

            _hostPersistencia.StartAsync();


            _hostContato = Host.CreateDefaultBuilder()
                        .ConfigureServices((context, services) =>
                        {
                            services.AddHostedService<Fiap.TechChallenge.Fase3.Contato.Worker>();

                            InjecaoDependenciaWorkers.ResolverDependencia(services);

                            services.AddSingleton<IContatoServices, ContatoServices>();
                            services.AddSingleton<IConsumers, Consumers>();

                            services.AddDbContext<ContextTechChallenge>(options =>
                            {
                                var configuration = context.Configuration;
                                options.UseNpgsql(configuration.GetConnectionString("conexao"), x => x.MigrationsAssembly("Fiap.TechChallenge.Fase1.Data")).UseLowerCaseNamingConvention();
                            }, ServiceLifetime.Singleton);
                        })
                        .Build();

            _hostContato.StartAsync();

            _hostUsuario = Host.CreateDefaultBuilder()
                        .ConfigureServices((context, services) =>
                        {
                            services.AddHostedService<Fiap.TechChallenge.Fase3.Usuario.Worker>();

                            InjecaoDependenciaWorkers.ResolverDependencia(services);

                            services.AddSingleton<IUsuarioServices, UsuarioServices>();
                            services.AddSingleton<IConsumers, Consumers>();

                            services.AddDbContext<ContextTechChallenge>(options =>
                            {
                                var configuration = context.Configuration;
                                options.UseNpgsql(configuration.GetConnectionString("conexao"), x => x.MigrationsAssembly("Fiap.TechChallenge.Fase1.Data")).UseLowerCaseNamingConvention();
                            }, ServiceLifetime.Singleton);
                        })
                        .Build();

            _hostUsuario.StartAsync();

        }

        private async Task<bool> AguardarContainerRabbitMQEstarProntoParaConexao(DockerClient client)
        {
            var maximoTentativas = 20;

            for (int i = 0; i < maximoTentativas; i++)
            {
                try
                {
                    var connection = await Task.FromResult(_configuracaoRabbit.AbrirConexaoRabbitMQ());
                    var channel = connection.CreateModel();
                    channel.BasicQos(0, 1, false);

                    _gerenciamentoFila.CriarFilas(channel);
                    await Task.Delay(5000);

                    return true;                    
                }
                catch
                {
                    await Task.Delay(5000);
                }
            }

            return false;
        }

        private async Task<bool> AguardarContainerPostgresEstarProntoParaConexao()
        {
            var maximoTentativas = 20;

            for (int i = 0; i < maximoTentativas; i++)
            {
                try
                {
                    using (var connection = new NpgsqlConnection(GetConnectionString()))
                    {
                        await connection.OpenAsync();
                        return true;
                    }
                }
                catch
                {
                    await Task.Delay(5000);
                }
            }

            return false;
        }

        public string GetConnectionString()
        {
            var _connectionString = $"Server=localhost;Port=5432;Database=techchallenge;User Id=postgres;Password=102030;";
            return _connectionString;
        }

        public void Dispose()
        {
            var existingContainer = _dockerClient.Containers.ListContainersAsync(new ContainersListParameters { All = true }).GetAwaiter().GetResult()
                    .FirstOrDefault(c => c.Names.Contains($"/{containerName}"));

            if (existingContainer != null)
            {
                _hostContato.StopAsync().Wait();
                _hostUsuario.StopAsync().Wait();
                _hostPersistencia.StopAsync().Wait();

                _containerId = existingContainer.ID;
                if (existingContainer.State == "running")
                {
                    //_dockerClient.Containers.StopContainerAsync(_containerId, new ContainerStopParameters()).GetAwaiter().GetResult();
                    //_dockerClient.Containers.RemoveContainerAsync(_containerId, new ContainerRemoveParameters()).GetAwaiter().GetResult();
                    //_dockerClient.Dispose();
                }
            }            
        }
    }
}