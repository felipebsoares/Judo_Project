using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoJudo.Application.Contracts.Services;
using ProjetoJudo.Application.DTOs.Agremiacoes;
using ProjetoJudo.Application.Notification;

namespace ProjetoJudo.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AgremiacaoController : Controller
{
    private readonly IAgremiacaoService _autenticacaoService;
    private readonly INotificator _notificator;
    private readonly IValidator<CadastrarAgremiacaoDto> _validator;
    private readonly IMapper _mapper;
    private List<CadastrarAgremiacaoDto> Banco = new();

    public AgremiacaoController(IAgremiacaoService autenticacaoService, INotificator notificator, IValidator<CadastrarAgremiacaoDto> validator, IMapper mapper)
    {
        _autenticacaoService = autenticacaoService;
        _notificator = notificator;
        _validator = validator;
        _mapper = mapper;
    }
    
    [HttpPost("Cadastrar")]
    public async Task<IActionResult> Registrar([FromBody] CadastrarAgremiacaoDto dto)
    {
        var validacao = await _validator.ValidateAsync(dto);

        if (!validacao.IsValid)
        { 
            _notificator.Handle(validacao.Errors);
            return null;
        }
        
        var bancodto = Banco.FirstOrDefault(c => c.Nome == dto.Nome &&
                                                 c.Cnpj == dto.Cnpj);
        if (bancodto != null)
        {
            _notificator.Handle("Já existe uma agremiação com mesmo nome e CNPJ cadastrados no banco!");
        }
        
        Banco.Add(dto);
        return Ok(dto);
    }
    
    [HttpPut("Alterar")]
    public async Task<IActionResult> Alterar([FromBody] CadastrarAgremiacaoDto dto)
    {
        var validacao = await _validator.ValidateAsync(dto);

        if (!validacao.IsValid)
        { 
            _notificator.Handle(validacao.Errors);
            return null;
        }

        var bancodto = Banco.FirstOrDefault(c => c.Nome == dto.Nome &&
                                                 c.Cnpj == dto.Cnpj);
        if (bancodto != null)
        {
            _notificator.Handle("Já existe uma agremiação com mesmo nome e CNPJ cadastrados no banco!");
        }

        var alteraragremiacao = Banco.FirstOrDefault(c => c.Id == dto.Id);
        if (alteraragremiacao is null)
        {
            _notificator.HandleNotFoundResource();
            return null;
        }
        
        _mapper.Map(dto, alteraragremiacao);
        Banco.Add(alteraragremiacao);
        return Ok(dto);
    }
    
    [HttpDelete("Deletar/{id}")]
    public async Task<IActionResult> Deletar(int id)
    {
        _autenticacaoService.Deletar(id);

        if (_notificator.HasError) return BadRequest(_notificator.Errors);
        return Ok();
    }
    
    [HttpGet("Listar")]
    public async Task<IActionResult> Listar()
    {
        var lista =  Banco.ToList();; ;
        return Ok(lista);
    }
    
    [HttpGet("Obter/{id}")]
    public async Task<IActionResult> Obter(int id)
    {
        var lista = _autenticacaoService.Obter(id);

        if (_notificator.HasError) return BadRequest(_notificator.Errors);
        return Ok(lista);
    }
}