using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Domain.Contracts.Repositories;

public interface ITbAtletaRepository : IRepository<TbAtleta>
{
    void Create(TbAtleta atleta);
    void Update(TbAtleta atleta);
    Task<TbAtleta?> ObterPorCpf(string cfp);
    Task<List<TbAtleta>?> ObterTodos();
    Task<TbAtleta?> Remover(string cpf);
}