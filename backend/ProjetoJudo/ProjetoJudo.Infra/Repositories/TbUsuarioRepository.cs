using ProjetoJudo.Domain.Contracts.Repositories;
using ProjetoJudo.Domain.Entities;
using ProjetoJudo.Infra.Abstractions;
using ProjetoJudo.Infra.Context;

namespace ProjetoJudo.Infra.Repositories;

public class TbUsuarioRepository : Repository<TbUsuario>, ITbUsuarioRepository
{
    public TbUsuarioRepository(JudoDesContext context) : base(context)
    {
    }

    public void Cadastrar(TbUsuario usuario)
    {
        Context.TbUsuarios.Add(usuario);
    }
}