using ProjetoJudo.Application.DTOs.Atleta;

namespace ProjetoJudo.Application.Contracts;

public interface IAtletaService
{
    Task<AtletaDto> Create(CreateAtletaDto dto);
    Task<AtletaDto> Update(int id, UpdateAtletaDto dto);
    Task<AtletaDto?> ObterPorId(int id);
    Task<List<AtletaDto?>> ObterTodos();
    void Remover(int id);
}