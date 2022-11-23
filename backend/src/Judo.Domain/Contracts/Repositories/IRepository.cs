using Judo.Domain.Models;

namespace Judo.Domain.Contracts.Repositories;

public interface IRepository<T> : IDisposable where T : Entity
{
    
}