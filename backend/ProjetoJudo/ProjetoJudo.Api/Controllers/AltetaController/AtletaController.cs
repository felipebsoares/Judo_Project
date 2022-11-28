using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoJudo.Application.Contracts;
using ProjetoJudo.Application.DTOs.Atleta;
using ProjetoJudo.Application.DTOs.Usuarios;

namespace ProjetoJudo.Api.Controllers.AltetaController
{
    [ApiController]
    [Route("[controller]")]
    
    public class AtletaController : ControllerBase
    {
        private readonly IAtletaService _atletaService;

        public AtletaController(IAtletaService atletaService)
        {
            _atletaService = atletaService;
        }
        
        [HttpPost("Registrar-Atleta")]
        [Authorize]
        public async Task<IActionResult> Create([FromBody] CreateAtletaDto dto)
        {
            var atleta = await _atletaService.Create(dto);
            return Ok(atleta);
        }
        
        [HttpPut("Atualizar-Atleta-{id}")]
        [Authorize]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateAtletaDto dto)
        {
            var atleta = await _atletaService.Update(id, dto);
            return Ok(atleta);
        }
    }
}
