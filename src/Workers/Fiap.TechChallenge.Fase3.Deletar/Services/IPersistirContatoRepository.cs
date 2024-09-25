using Fiap.TechChallenge.Fase1.Dominio.Entidades;
using Fiap.TechChallenge.Fase1.Infraestructure.DTO.Contato;

namespace Fiap.TechChallenge.Fase3.Persistencia.Services
{
    public interface IPersistirContatoRepository
    {
        Task<bool> CadastrarContatoRepository(Contato contato);
        Task<bool> AlterarContatoRepository(Contato contato);
        Task<bool> RemoverContatoRepository(Guid contatoId);
    }
}
