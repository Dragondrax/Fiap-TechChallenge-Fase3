using Fiap.TechChallenge.Fase1.Data.Context;
using Fiap.TechChallenge.Fase1.IoC;
using Fiap.TechChallenge.Fase3.Deletar;
using Fiap.TechChallenge.Fase3.Persistencia.Consumers;
using Fiap.TechChallenge.Fase3.Persistencia.Services;
using Microsoft.EntityFrameworkCore;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

InjecaoDependenciaWorkers.ResolverDependencia(builder.Services);

builder.Services.AddSingleton<IPersistirContatoRepository, PersistirContatoRepository>();
builder.Services.AddSingleton<IConsumer, Consumers>();

builder.Services.AddDbContext<ContextTechChallenge>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("conexao"), x => x.MigrationsAssembly("Fiap.TechChallenge.Fase1.Data")).UseLowerCaseNamingConvention();
}, ServiceLifetime.Singleton);

var host = builder.Build();
host.Run();
