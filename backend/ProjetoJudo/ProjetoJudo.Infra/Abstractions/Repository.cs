using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ProjetoJudo.Domain.Contracts;
using ProjetoJudo.Domain.Contracts.Paginacao;
using ProjetoJudo.Domain.Contracts.Repositories;
using ProjetoJudo.Infra.Context;
using ProjetoJudo.Infra.Extensions;

namespace ProjetoJudo.Infra.Abstractions;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private bool _isDisposed;
    private readonly DbSet<TEntity> _dbSet;
    protected readonly JudoDesContext Context;
    
    protected Repository(JudoDesContext context)
    {
        Context = context;
        _dbSet = context.Set<TEntity>();
    }

    public IUnitOfWork UnitOfWork => Context;
    
    public virtual async Task<IResultadoPaginado<TEntity>> Buscar(IBuscaPaginada<TEntity> filtro, CancellationToken cancellationToken = default)
    {
        var queryable = _dbSet.AsQueryable();
        
        filtro.AplicarFiltro(ref queryable);
        filtro.AplicarOrdenacao(ref queryable);

        return await queryable.BuscarPaginadoAsync(filtro.Pagina, filtro.TamanhoPagina, cancellationToken);
    }

    public async Task<IResultadoPaginado<TEntity>> Buscar(IQueryable<TEntity> queryable, IBuscaPaginada<TEntity> filtro, CancellationToken cancellationToken = default)
    {
        filtro.AplicarFiltro(ref queryable);
        filtro.AplicarOrdenacao(ref queryable);
        
        return await queryable.BuscarPaginadoAsync(filtro.Pagina, filtro.TamanhoPagina, cancellationToken);
    }

    public async Task<List<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
    {
        return await _dbSet.AsNoTrackingWithIdentityResolution().Where(predicate).ToListAsync(cancellationToken);
    }

    public async Task<TEntity?> FistOrDefault(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
    {
        return await _dbSet.AsNoTrackingWithIdentityResolution().Where(predicate)
            .FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<int> Count(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default) 
        => await _dbSet.CountAsync(predicate, cancellationToken);

    public async Task<bool> Any(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default) 
        => await _dbSet.AnyAsync(predicate, cancellationToken);

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    
    protected virtual void Dispose(bool disposing)
    {
        if (_isDisposed) return;

        if (disposing)
        {
            // free managed resources
            Context.Dispose();
        }

        _isDisposed = true;
    }
    
    ~Repository()
    {
        Dispose(false);
    }
}