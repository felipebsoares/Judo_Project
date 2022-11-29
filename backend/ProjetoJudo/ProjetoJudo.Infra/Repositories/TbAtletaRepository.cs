// using Microsoft.EntityFrameworkCore;
// using ProjetoJudo.Domain.Contracts.Repositories;
// using ProjetoJudo.Domain.Entities;
// using ProjetoJudo.Infra.Abstractions;
// using ProjetoJudo.Infra.Context;
//
// namespace ProjetoJudo.Infra.Repositories;
//
// public class TbAtletaRepository : Repository<TbAtleta>, ITbAtletaRepository
// {
//     public TbAtletaRepository(JudoDesContext context) : base(context)
//     {
//     }
//
//     public void Create(TbAtleta atleta)
//     {
//         Context.TbAtletas.Add(atleta);
//     }
//
//     public void Update(TbAtleta atleta)
//     {
//         Context.TbAtletas.Update(atleta);
//     }
//
//     public async Task<TbAtleta?> ObterPorCpf(string cpf)
//     {
//         return await FistOrDefault(c => c.Cpf == cpf);
//     }
//
//     public async Task<List<TbAtleta>?> ObterTodos()
//     {
//         var allUsers =await Context.Set<TbAtleta>()
//             .AsNoTracking()
//             .ToListAsync();
//
//         return allUsers;
//     }
//
//     public async Task<TbAtleta?> Remover(string cpf)
//     {
//         var atleta = await ObterPorCpf(cpf);
//         if (atleta != null)
//         {
//             Context.TbAtletas.Remove(atleta);
//         }
//
//         return atleta;
//     }
// }