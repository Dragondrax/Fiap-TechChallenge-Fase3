using Fiap.TechChallenge.Fase1.SharedKernel.RabbitMQ;
using Fiap.TechChallenge.Fase3.RabbitMQ.GerenciamentoFilas;

namespace Fiap.TechChallenge.Fase3.Deletar
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IConfiguracoesRabbitMQ _configuracoesRabbit;
        private readonly IGerenciamentoFilasRabbitMQ _gerenciamentoFila;

        public Worker(ILogger<Worker> logger,
                      IConfiguracoesRabbitMQ configuracoesRabbit,
                      IGerenciamentoFilasRabbitMQ gerenciamentoFila)
        {
            _logger = logger;
            _configuracoesRabbit = configuracoesRabbit;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var connection = _configuracoesRabbit.AbrirConexaoRabbitMQ();
            var channel = connection.CreateModel();

            _gerenciamentoFila.CriarFilas(channel);
            _consumer.ConsumerEnviarNotificacao(channel);
            _consumer.ConsumerMarcarNotificacaoComoLida(channel);
        }
    }
}
