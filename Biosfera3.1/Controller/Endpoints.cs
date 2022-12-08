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
                Id = model.Id,
                Nome = model.Nome
            };
            await _pesquisadorService.SalvarPesquisador(pesquisador);
            return Ok(pesquisador);
        }
        
        [HttpGet("verificaJardim")]
        public async Task<IActionResult> GetAsync(Area model)
        {
            var area = new Area()
            {
                Id = model.Id,
                Nome = model.Nome,
                Sensor = model.Sensor,
                Pesquisador_1 = model.Pesquisador_1,
                Pesquisador_2 = model.Pesquisador_2,
                Pesquisador_3 = model.Pesquisador_3
            };
            await _pesquisadorService.(pesquisador);
            return Ok(pesquisador);
        }
    }
}
