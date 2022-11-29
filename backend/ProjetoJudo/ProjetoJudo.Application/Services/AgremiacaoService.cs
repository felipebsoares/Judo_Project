using AutoMapper;
using FluentValidation;
using ProjetoJudo.Application.Contracts.Services;
using ProjetoJudo.Application.DTOs.Agremiacoes;
using ProjetoJudo.Application.Notification;

namespace ProjetoJudo.Application.Services;

public class AgremiacaoService : IAgremiacaoService
{
    private readonly INotificator _notificator;
    private readonly IValidator<CadastrarAgremiacaoDto> _validator;
    private readonly IMapper _mapper;
    private List<CadastrarAgremiacaoDto> Banco = new();

    public AgremiacaoService(INotificator notificator, IValidator<CadastrarAgremiacaoDto> validator, IMapper mapper)
    {
        _notificator = notificator;
        _validator = validator;
        _mapper = mapper;
    }

    public async Task<CadastrarAgremiacaoDto?> Cadastrar(CadastrarAgremiacaoDto dto)
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
        return dto;
    }

    public async Task<CadastrarAgremiacaoDto?> Alterar(CadastrarAgremiacaoDto dto)
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
        return dto;
    }

    public void Deletar(int id)
    {
        var alteraragremiacao = Banco.FirstOrDefault(c => c.Id == id);
        if (alteraragremiacao is null)
        {
            _notificator.HandleNotFoundResource();
            return;
        }
        Banco.Remove(alteraragremiacao);
    }

    public List<CadastrarAgremiacaoDto> Listar()
    {
        return Banco.ToList();
    }

    public CadastrarAgremiacaoDto? Obter(int id)
    {
        var alteraragremiacao = Banco.FirstOrDefault(c => c.Id == id);
        if (alteraragremiacao is null)
        {
            _notificator.HandleNotFoundResource();
            return null;
        }

        return alteraragremiacao;
    }
}