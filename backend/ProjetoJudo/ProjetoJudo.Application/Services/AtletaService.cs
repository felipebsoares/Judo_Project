using System.Runtime.CompilerServices;
using AutoMapper;
using FluentValidation;
using ProjetoJudo.Application.Contracts;
using ProjetoJudo.Application.DTOs.Atleta;
using ProjetoJudo.Application.DTOs.Usuarios;
using ProjetoJudo.Application.Notification;
using ProjetoJudo.Domain.Contracts.Repositories;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Application.Services;

public class AtletaService : IAtletaService
{
    private readonly IAtletaRepository _atletaRepository;
    private readonly INotificator _notificator;
    private readonly IMapper _mapper;
    private readonly IValidator<TbAtleta> _validator;

    public AtletaService(IAtletaRepository atletaRepository, INotificator notificator, IMapper mapper, IValidator<TbAtleta> validator)
    {
        _atletaRepository = atletaRepository;
        _notificator = notificator;
        _mapper = mapper;
        _validator = validator;
    }

    public async Task<AtletaDto> Create(CreateAtletaDto dto)
    {
        var atleta = _mapper.Map<TbAtleta>(dto);
        var validacao = await _validator.ValidateAsync(atleta);
        if (!validacao.IsValid)
        {
            _notificator.Handle(validacao.Errors);
            return null;
        }

        var atletaExistente = await _atletaRepository.FistOrDefault(at => at.Cep == atleta.Cpf);
        if (atletaExistente != null)
        {
            _notificator.Handle("Atleta já existente");
            return null;
        }
        
        _atletaRepository.Create(atleta);
        if (!await _atletaRepository.UnitOfWork.Commit())
        {
            _notificator.Handle("Não foi possível salvar o atleta");
            return null;
        }

        return _mapper.Map<AtletaDto>(atleta);
    }

    public async Task<AtletaDto> Update(int id, UpdateAtletaDto dto)
    {
        if (id != dto.Id)
        {
            _notificator.Handle("Os ids não conferem");
            return null;
        }

        var atleta = _mapper.Map<TbAtleta>(dto);
        var validacao = await _validator.ValidateAsync(atleta);
        if (!validacao.IsValid)
        {
            _notificator.Handle(validacao.Errors);
            return null;
        }

        var atletaUpdated = await _atletaRepository.FistOrDefault(at => at.Id == atleta.Id);
        if (atletaUpdated == null)
        {
            _notificator.Handle("Nã existe um atleta com o Id informado");
            return null;
        }

        _mapper.Map(atleta, atletaUpdated);
        _atletaRepository.Update(atletaUpdated);
        if (!await _atletaRepository.UnitOfWork.Commit())
        {
            _notificator.Handle("Não foi possível alterar o atleta");
            return null;
        }

        return _mapper.Map<AtletaDto>(atletaUpdated);
    }

    public Task<AtletaDto?> ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<AtletaDto?>> ObterTodos()
    {
        throw new NotImplementedException();
    }

    public void Remover(int id)
    {
        throw new NotImplementedException();
    }
}