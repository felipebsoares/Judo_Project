using ProjetoJudo.Domain.Contracts.Repositories;
using ProjetoJudo.Domain.Entities;
using ProjetoJudo.Infra.Abstractions;
using ProjetoJudo.Infra.Context;

namespace ProjetoJudo.Infra.Repositories;

public class TbAgremiacaoRepository : Repository<TbAgremiaco>, ITbAgremiacaoRepository
{
    public TbAgremiacaoRepository(JudoDesContext context) : base(context)
    {
    }

    public void Cadastrar(TbAgremiaco agremiacao)
    {
        Context.TbAgremiacoes.Add(agremiacao);
    }

    public void Alterar(TbAgremiaco agremiacao)
    {
        Context.TbAgremiacoes.Update(agremiacao);
    }
}