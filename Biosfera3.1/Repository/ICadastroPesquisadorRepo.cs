using Biosfera3.Models;

namespace Biosfera3.Repository
{
    public interface ICadastroPesquisadorRepo
    {
        Task SalvarPesquisador(Pesquisador pesquisador);
    }
}
