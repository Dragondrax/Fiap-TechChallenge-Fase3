namespace Fiap.TechChallenge.Fase1.SharedKernel.RabbitMQ
{
    public interface IPublicaMensagemNaFila
    {
        Task PublicarMensagem(string fila, string exchange, object messageBody);
    }
}
