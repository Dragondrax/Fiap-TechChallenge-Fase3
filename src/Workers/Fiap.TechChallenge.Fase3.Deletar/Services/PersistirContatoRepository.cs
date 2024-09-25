using Fiap.TechChallenge.Fase1.Dominio;
using Fiap.TechChallenge.Fase1.Dominio.Entidades;
using Fiap.TechChallenge.Fase1.Infraestructure.DTO.Contato;

namespace Fiap.TechChallenge.Fase3.Persistencia.Services
{
    public class PersistirContatoRepository(IContatoRepository contatoRepository) : IPersistirContatoRepository
    {
        private readonly IContatoRepository _contatoRepository = contatoRepository;

        public async Task<bool> CadastrarContatoRepository(Contato contato)
        {
            try
            {
                var dadosContrato = await _contatoRepository.ObterPorEmailAsync(contato.Email.ToLower());

                if (dadosContrato != null)
                    return false;

                await _contatoRepository.AdicionarAsync(contato);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> AlterarContatoRepository(Contato contato)
        {
            try
            {
                var dadosContrato = await _contatoRepository.ObterPorEmailAsync(contato.Email.ToLower());

                if (dadosContrato == null)
                    return false;

                await _contatoRepository.AtualizarAsync(contato);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> RemoverContatoRepository(Guid contatoId)
        {
            try
            {
                var contato = await _contatoRepository.ObterPorIdAsync(contatoId);

                if (contato == null)
                    return false;

                await _contatoRepository.RemoverAsync(contato);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
