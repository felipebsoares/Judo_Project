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
        private static readonly List<CreateAtletaDto> Atletas = new();

        public AtletaController(INotificator notificator)
        {
            _notificator = notificator;
        }

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
            
            dto.IdAtleta = Atletas.Count;
            Atletas.Add(dto);
            return Ok(dto);
        }
        
        //[Authorize]
        [HttpPut("Atualizar-Atleta")]
        public async Task<IActionResult> Update([FromBody] UpdateAtletaDto dto)
        {
            var atleta = Atletas.FirstOrDefault(c => c.IdAtleta == dto.IdAtleta);
            if (atleta == null)
            {
                _notificator.HandleNotFoundResource();
                return null;
            }

            atleta.IdAtleta = dto.IdAtleta;
            atleta.RegistroFederacao = dto.RegistroFederacao;
            atleta.RegistroConfederacao = dto.RegistroConfederacao;
            atleta.Nome = dto.Nome;
            atleta.DataNascimento = dto.DataNascimento;
            atleta.DataFiliacao = dto.DataFiliacao;
            atleta.IdAgremiacao = dto.IdAgremiacao;
            atleta.Cep = dto.Cep;
            atleta.Endereco = dto.Endereco;
            atleta.Bairro = dto.Bairro;
            atleta.Complemento = dto.Complemento;
            atleta.IdCidade = dto.IdCidade;
            atleta.IdEstado = dto.IdEstado;
            atleta.IdPais = dto.IdPais;
            atleta.Telefone = dto.Telefone;
            atleta.Email = dto.Email;
            atleta.Cpf = dto.Cpf;
            atleta.Identidade = dto.Identidade;
            atleta.DataIdentidade = dto.DataIdentidade;
            atleta.IdEmissor = dto.IdEmissor;
            atleta.IdNacionalidade = dto.IdNacionalidade;
            atleta.IdProfissaoAtleta = dto.IdProfissaoAtleta;
            atleta.NomePai = dto.NomePai;
            atleta.IdProfissaoPai = dto.IdProfissaoPai;
            atleta.NomeMae = dto.NomeMae;
            atleta.IdProfissaoMae = dto.IdProfissaoMae;
            atleta.IdFaixa = dto.IdFaixa;
            atleta.IdSexo = dto.IdSexo;
            atleta.IdEstadoCivil = dto.IdEstadoCivil;
            atleta.Anotacoes = dto.Anotacoes;
            atleta.Selecao = dto.Selecao;
            atleta.IdCliente = dto.IdCliente;

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
        
        [HttpDelete("Remover-Atleta-por-{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var atleta = Atletas.FirstOrDefault(c => c.IdAtleta == id);
            if (atleta == null)
            {
                _notificator.HandleNotFoundResource();
                return null;
            }

            Atletas.Remove(atleta);
            return Ok(Atletas);
        }
    }
    
}
