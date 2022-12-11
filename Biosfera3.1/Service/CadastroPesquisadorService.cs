using Biosfera3.Models;
using Biosfera3.Repository;

namespace Biosfera3.Service
{
    public class CadastroPesquisadorService : ICadastroPesquisadorService
    {
        private ICadastroPesquisadorRepo _pesquisadorRepo;
        public CadastroPesquisadorService(ICadastroPesquisadorRepo pesquisadorRepo)
        {
            _pesquisadorRepo = pesquisadorRepo;
        }

        public async Task<Pesquisador> SalvarPesquisador(Pesquisador pesquisador)
        {
            await _pesquisadorRepo.SalvarPesquisador(pesquisador);
            return pesquisador;
        }
    }
}
