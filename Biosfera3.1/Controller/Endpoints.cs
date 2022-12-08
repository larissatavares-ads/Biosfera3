using Biosfera3.Models;
using Biosfera3.Service;
using Microsoft.AspNetCore.Mvc;

namespace Biosfera3.Controller
{
    public class Endpoints : ControllerBase
    {
        private ICadastroPesquisadorService _pesquisadorService;
        public Endpoints(ICadastroPesquisadorService pesquisadorService)
        {
            _pesquisadorService = pesquisadorService;
        }

        [HttpPost("criarPesquisador")]
        public async Task<IActionResult> PostAsync([FromBody] Pesquisador model)
        {
            var pesquisador = new Pesquisador()
            {
                Id = model.Id,
                Nome = model.Nome
            };
            await _pesquisadorService.SalvarPesquisador(pesquisador);
            return Ok(pesquisador);
        }
    }
}
