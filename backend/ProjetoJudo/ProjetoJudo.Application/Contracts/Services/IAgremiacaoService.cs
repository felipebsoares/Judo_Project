using ProjetoJudo.Application.DTOs.Agremiacoes;

namespace ProjetoJudo.Application.Contracts.Services;

public interface IAgremiacaoService
{
    Task<CadastrarAgremiacaoDto?> Cadastrar(CadastrarAgremiacaoDto dto);
    Task<CadastrarAgremiacaoDto?> Alterar(CadastrarAgremiacaoDto dto);
    void Deletar(int id);
    List<CadastrarAgremiacaoDto> Listar();
    CadastrarAgremiacaoDto? Obter(int id);
}