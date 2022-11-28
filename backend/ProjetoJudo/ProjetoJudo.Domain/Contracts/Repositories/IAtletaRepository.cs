using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Domain.Contracts.Repositories;

public interface IAtletaRepository : IRepository<TbAtleta>
{
    void Create(TbAtleta tbAtleta);
    void Update(TbAtleta tbAtleta);
    Task<TbAtleta?> ObterPorId(int id);
    Task<List<TbAtleta?>> ObterTodos();
    void Remover(TbAtleta tbAtleta);
}