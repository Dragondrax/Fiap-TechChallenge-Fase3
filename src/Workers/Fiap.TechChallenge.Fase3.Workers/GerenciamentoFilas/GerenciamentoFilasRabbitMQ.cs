using Fiap.TechChallenge.Fase1.SharedKernel.Filas;
using RabbitMQ.Client;

namespace Fiap.TechChallenge.Fase3.RabbitMQ.GerenciamentoFilas
{
    public class GerenciamentoFilasRabbitMQ : IGerenciamentoFilasRabbitMQ
    {
        private string Exchange = "techchallenge";
        private string ExchangeDeadLetter = "techchallenge.deadletter";

        public void CriarFilas(IModel channel)
        {
            DeclararExchange(channel);
            CriarFila(channel,
                      FilasPersistencia.CriarContato,
                      Exchange,
                      FilasPersistencia.CriarContatoDeadLetter,
                      ExchangeDeadLetter);

            CriarFila(channel,
                      FilasPersistencia.CriarUsuario,
                      Exchange,
                      FilasPersistencia.CriarUsuarioDeadLetter,
                      ExchangeDeadLetter);

            CriarFila(channel,
                      FilasPersistencia.AtualizarContato,
                      Exchange,
                      FilasPersistencia.AtualizarContatoDeadLetter,
                      ExchangeDeadLetter);

            CriarFila(channel,
                      FilasPersistencia.AtualizarUsuario,
                      Exchange,
                      FilasPersistencia.AtualizarUsuarioDeadLetter,
                      ExchangeDeadLetter);

            CriarFila(channel,
                      FilasPersistencia.ExcluirContato,
                      Exchange,
                      FilasPersistencia.ExcluirContatoDeadLetter,
                      ExchangeDeadLetter);

            CriarFila(channel,
                      FilasPersistencia.ExcluirUsuario,
                      Exchange,
                      FilasPersistencia.ExcluirUsuarioDeadLetter,
                      ExchangeDeadLetter);
        }
        private void CriarFila(IModel channel, string fila, string exchange, string filaDeadLetter, string exchangeDeadLetter)
        {
            //Cria Fila Normal
            var argsFila = ObterArgumentoDaFila(fila, exchangeDeadLetter);
            channel.QueueDeclare(queue: fila,
                                     durable: true,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: argsFila);

            channel.QueueBind(fila, exchange, fila, null);

            //Cria Fila DeadLetter
            var argsDlq = ObterArgumentoDaFilaDeadLetter(filaDeadLetter, exchange);
            channel.QueueDeclare(filaDeadLetter, true, false, false, argsDlq);
            channel.QueueBind(filaDeadLetter, exchangeDeadLetter, fila, null);

        }
        private void DeclararExchange(IModel channel)
        {
            channel.ExchangeDeclare(Exchange, "direct", true, false);
            channel.ExchangeDeclare(ExchangeDeadLetter, "direct", true, false);
        }
        private Dictionary<string, object> ObterArgumentoDaFila(string fila, string exchangeDeadLetter)
        {
            var args = new Dictionary<string, object>();

            args.Add("x-dead-letter-exchange", exchangeDeadLetter);
            args.Add("x-queue-mode", "lazy");

            return args;
        }

        private Dictionary<string, object> ObterArgumentoDaFilaDeadLetter(string fila, string exchange)
        {
            var argsDlq = new Dictionary<string, object>();

            argsDlq.Add("x-queue-mode", "lazy");
            argsDlq.Add("x-dead-letter-exchange", exchange);

            return argsDlq;
        }
    }
}
