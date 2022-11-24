namespace ProjetoJudo.Domain.Contracts;

public interface IUnitOfWork
{
    Task<bool> Commit();
}