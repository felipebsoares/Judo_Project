using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
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

        public static class lista
        {
            private static List<CreateAtletaDto> atletas = new();
        }


        public AtletaController(IAtletaService atletaService)
        {
            _atletaService = atletaService;
            
        }
        
        [HttpPost("Registrar-Atleta")]
        public Task<IActionResult> Create([FromBody] CreateAtletaDto dto)
        {
            atletas.Add(dto);
            Atletas.Add(dto);
            return Ok(dto);
        }
        
        [HttpPut("Atualizar-Atleta-{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateAtletaDto dto)
        {
            var atleta = await _atletaService.Update(id, dto);
            return Ok(atleta);
        }

        [HttpGet("{cpf}")]
        public async Task<IActionResult> GetByCpf(string cpf)
        {
            var atleta = Atletas.FirstOrDefault(c => c.Cpf == cpf);
            if (atleta == null)
            {
                return null;
            }

            return Ok(atleta);
        }
    }
}
