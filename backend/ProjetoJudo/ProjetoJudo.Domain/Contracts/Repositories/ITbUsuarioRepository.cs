using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Domain.Contracts.Repositories;

public interface ITbUsuarioRepository : IRepository<TbUsuario>
{
    void Cadastrar(TbUsuario usuario);
}