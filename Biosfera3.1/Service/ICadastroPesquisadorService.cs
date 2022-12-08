using Biosfera3.Models;

namespace Biosfera3.Service
{
    public interface ICadastroPesquisadorService
    {
        Task<Pesquisador> SalvarPesquisador(Pesquisador pesquisador);
    }
}
