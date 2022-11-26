using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Domain.Contracts.Repositories;

public interface IUsuarioRepository : IRepository<TbUsuario>
{
    void Cadastrar(TbUsuario usuario);
}