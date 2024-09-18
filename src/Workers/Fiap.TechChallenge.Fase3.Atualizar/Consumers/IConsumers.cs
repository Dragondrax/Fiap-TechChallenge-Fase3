﻿using RabbitMQ.Client;

namespace Fiap.TechChallenge.Fase3.Contato.Consumers
{
    public interface IConsumers
    {
        public void ConsumerCriarContato(IModel channel);
        public void ConsumerAtualizarContato(IModel channel);
        public void ConsumerDeletarContato(IModel channel);
    }
}
