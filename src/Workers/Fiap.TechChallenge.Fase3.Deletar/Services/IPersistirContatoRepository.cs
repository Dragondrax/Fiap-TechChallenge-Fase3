using Fiap.TechChallenge.Fase1.Dominio.Entidades;

namespace Fiap.TechChallenge.Fase3.Persistencia.Services
{
    public interface IPersistirContatoRepository
    {
        Task<bool> Handle(Contato contato);
    }
}
