using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoJudo.Application.Contracts.Services;
using ProjetoJudo.Application.DTOs.Atleta;
using ProjetoJudo.Application.Notification;
using ProjetoJudo.Domain.Entities;
using ProjetoJudo.Infra.Abstractions;

namespace ProjetoJudo.Api.Controllers.Atleta
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtletaController : ControllerBase
    {
        // private readonly IAtletaService _atletaSercice;
        // private readonly IMapper _mapper;
        private readonly INotificator _notificator;

        public AtletaController(INotificator notificator)
        {
            _notificator = notificator;
        }

        public List<CreateAtletaDto> Atletas { get; set; } = new();
        
        // public AtletaController(IAtletaService atletaSercice, IMapper mapper, INotificator notificator)
        // {
        //     _atletaSercice = atletaSercice;
        //     _mapper = mapper;
        //     _notificator = notificator;
        // }

        //[Authorize]
        [HttpPost("Criar-Atleta")]
        public async Task<IActionResult> Create([FromBody] CreateAtletaDto dto)
        {
            var atleta = Atletas.FirstOrDefault(c => c.Cpf == dto.Cpf);
            if (atleta != null)
            {
                _notificator.Handle("Já existe um atleta com o cpf informado");
                return null;
            }
            Atletas.Add(dto);
            return Ok(dto);
        }
        
        //[Authorize]
        [HttpPut("Atualizar-Atleta")]
        public async Task<IActionResult> Update([FromBody] UpdateAtletaDto dto)
        {
            var atleta = Atletas.FirstOrDefault(c => c.Cpf == dto.Cpf);
            if (atleta == null)
            {
                _notificator.HandleNotFoundResource();
                return null;
            }

            atleta.Cpf = dto.Cpf;
            atleta.Email = dto.Email;
            atleta.Nome = dto.Nome;
            atleta.Telefone = dto.Telefone;
            atleta.DataNascimento = dto.DataNascimento;
            atleta.IdAtleta = dto.IdAtleta;

            return Ok(atleta);
        }
        
        //[Authorize]
        [HttpGet("obter-atleta-por-{cpf}")]
        public async Task<IActionResult?> GetByCpf(string cpf)
        {
            var atleta = Atletas.FirstOrDefault(c => c.Cpf == cpf);
            if (atleta == null)
            {
                _notificator.HandleNotFoundResource();
                return null;
            }
            
            return Ok(atleta);
        }
        
        //[Authorize]
        [HttpGet("Obter-todos-atletas")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(Atletas.ToList());
        }
    }
}
