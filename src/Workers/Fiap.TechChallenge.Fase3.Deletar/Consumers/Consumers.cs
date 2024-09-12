using Fiap.TechChallenge.Fase1.Dominio.Entidades;
using Fiap.TechChallenge.Fase1.SharedKernel.Filas;
using Fiap.TechChallenge.Fase3.Persistencia.Services;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;

namespace Fiap.TechChallenge.Fase3.Persistencia.Consumers
{
    public class Consumers : IConsumer
    {
        private readonly IPersistirContatoRepository _persistirContatoRepository;
        public Consumers(IPersistirContatoRepository persistirContatoRepository)
        {
            _persistirContatoRepository = persistirContatoRepository;
        }
        public void ConsumerAtualizarContato(IModel channel)
        {
            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += async (model, ea) =>
            {
                byte[] body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                var dadosMensagem = JsonSerializer.Deserialize<Contato>(message, options);

                var result = await _persistirContatoRepository.Handle(dadosMensagem);

                if (result)
                    channel.BasicAck(ea.DeliveryTag, false);
                else
                    channel.BasicReject(ea.DeliveryTag, false);
            };

            channel.BasicConsume(queue: FilasPersistencia.AtualizarContato,
                                 autoAck: false,
                                 consumer: consumer);
        }

        public void ConsumerAtualizarUsuario(IModel channel)
        {
            throw new NotImplementedException();
        }

        public void ConsumerCadastrarContato(IModel channel)
        {
            throw new NotImplementedException();
        }

        public void ConsumerCadastrarUsuario(IModel channel)
        {
            throw new NotImplementedException();
        }

        public void ConsumerDeletarContato(IModel channel)
        {
            throw new NotImplementedException();
        }

        public void ConsumerDeletarUsuario(IModel channel)
        {
            throw new NotImplementedException();
        }
    }
}
