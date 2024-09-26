using Fiap.TechChallenge.Fase1.Aplicacao;
using Fiap.TechChallenge.Fase1.Infraestructure.DTO;
using Fiap.TechChallenge.Fase1.Infraestructure.DTO.Usuario;
using Fiap.TechChallenge.Fase1.SharedKernel.Filas;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Fiap.TechChallenge.Fase3.Usuario.Consumers;

public class Consumers : IConsumers
{
    private readonly IUsuarioService _usuarioService;
    public Consumers(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }
    public void ConsumerAtualizarUsuario(IModel channel)
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
            var dadosMensagem = JsonSerializer.Deserialize<CriarAlterarUsuarioDTO>(message, options);

            var result = await _usuarioService.AlterarUsuario(dadosMensagem);

            if (result)
                channel.BasicAck(ea.DeliveryTag, false);
            else
                channel.BasicReject(ea.DeliveryTag, false);
        };

        channel.BasicConsume(queue: FilasContatos.AtualizarContatoService,
                             autoAck: false,
                             consumer: consumer);
    }

    public void ConsumerCriarUsuario(IModel channel)
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
            var dadosMensagem = JsonSerializer.Deserialize<CriarAlterarUsuarioDTO>(message, options);

            var result = await _usuarioService.SalvarUsuario(dadosMensagem);

            if (result)
                channel.BasicAck(ea.DeliveryTag, false);
            else
                channel.BasicReject(ea.DeliveryTag, false);
        };

        channel.BasicConsume(queue: FilasContatos.CriarContatoService,
                             autoAck: false,
                             consumer: consumer);
    }

    public void ConsumerDeletarUsuario(IModel channel)
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
            var dadosMensagem = JsonSerializer.Deserialize<DeletarUsuarioDto>(message, options);

            var result = await _usuarioService.RemoverUsuario(dadosMensagem.Id);

            if (result)
                channel.BasicAck(ea.DeliveryTag, false);
            else
                channel.BasicReject(ea.DeliveryTag, false);
        };

        channel.BasicConsume(queue: FilasContatos.DeletarContatoService,
                             autoAck: false,
                             consumer: consumer);
    }
}
}
