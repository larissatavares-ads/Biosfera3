using Biosfera3.Models;
using Biosfera3.Service;
using Microsoft.AspNetCore.Mvc;

namespace Biosfera3.Controller
{
    public class Endpoints : ControllerBase
    {
        private ICadastroPesquisadorService _pesquisadorService;
        private IAreaService _areaService;
        public Endpoints(ICadastroPesquisadorService pesquisadorService)
        {
            _pesquisadorService = pesquisadorService;
        }

        [HttpPost("criarPesquisador")]
        public async Task<IActionResult> PostAsync([FromBody] Pesquisador model)
        {
            var pesquisador = new Pesquisador()
            {
                Nome = model.Nome
            };
            await _pesquisadorService.SalvarPesquisador(pesquisador);
            return Ok(pesquisador);
        }
        
        [HttpGet("verificaJardim")]
        public async Task<IActionResult> GetAsync(Sensor model)
        {
            var pesquisador = new Sensor()
            {
                area = model.area,
                pesquisador = model.pesquisador
            };
            return Ok("Ok");
        }
    }
}
