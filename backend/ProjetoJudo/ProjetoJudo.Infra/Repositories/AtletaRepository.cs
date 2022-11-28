using Microsoft.EntityFrameworkCore;
using ProjetoJudo.Domain.Contracts.Repositories;
using ProjetoJudo.Domain.Entities;
using ProjetoJudo.Infra.Abstractions;
using ProjetoJudo.Infra.Context;

namespace ProjetoJudo.Infra.Repositories;

public class TbAtletaRepository : Repository<TbAtleta>, IAtletaRepository
{
    public TbAtletaRepository(JudoDesContext context) : base(context)
    {
    }

    public void Create(TbAtleta tbAtleta)
    {
        Context.TbAtletas.Add(tbAtleta);
    }

    public void Update(TbAtleta tbAtleta)
    {
        Context.Entry(tbAtleta).State = EntityState.Modified;
        Context.SaveChangesAsync();
    }

    public async Task<TbAtleta?> ObterPorId(int id)
    {
        return await FistOrDefault(at => at.Id == id);
    }

    public async Task<List<TbAtleta>?> ObterTodos()
    {
        var allUsers = await Context.Set<TbAtleta>()
            .AsNoTracking()
            .ToListAsync();

        return allUsers;
    }

    public void Remover(TbAtleta tbAtleta)
    {
        Context.TbAtletas.Remove(tbAtleta);
    }
}