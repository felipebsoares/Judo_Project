using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Domain.Contracts.Repositories;

public interface ITbAgremiacaoRepository : IRepository<TbAgremiaco>
{
    void Cadastrar(TbAgremiaco agremiacao);
    void Alterar(TbAgremiaco agremiacao);
}