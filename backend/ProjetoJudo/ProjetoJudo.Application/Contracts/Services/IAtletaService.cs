using ProjetoJudo.Application.DTOs.Atleta;

namespace ProjetoJudo.Application.Contracts.Services;

public interface IAtletaService
{
    Task<CreateAtletaDto> Create(CreateAtletaDto dto);
    Task<CreateAtletaDto> Update(CreateAtletaDto dto);
    Task<CreateAtletaDto?> ObterPorCpf(string cpf);
    Task<CreateAtletaDto?> ObterTodos();
    Task<CreateAtletaDto?> Remover(string cpf);

}