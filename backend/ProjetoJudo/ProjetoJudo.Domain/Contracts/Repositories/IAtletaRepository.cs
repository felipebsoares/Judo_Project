using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Domain.Contracts.Repositories;

public interface IAtletaRepository : IRepository<TbAtleta>
{
    void Create(TbAtleta tbAtleta);
    void Update(TbAtleta tbAtleta);
    Task<TbUsuario?> ObterPorId(int id);
    Task<TbUsuario?> ObterTodos();
    void Remover(TbAtleta tbAtleta);
}