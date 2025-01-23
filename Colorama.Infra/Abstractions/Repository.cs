using System.Linq.Expressions;
using Colorama.Domain.Context;
using Colorama.Domain.Contracts.Interfaces;
using Colorama.Domain.Contracts.Repositories;
using Colorama.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Colorama.Domain.Abstractions;

public abstract class Repository<T> : IRepository<T> where T : BaseEntity, IAggregateRoot
{
    protected readonly BaseApplicationDbContext Context;
    private readonly DbSet<T> _dbSet;
    private bool _isDisposed;

    protected Repository(BaseApplicationDbContext context)
    {
        Context = context;
        _dbSet = context.Set<T>();
    }
    
    public IUnitOfWork UnitOfWork => Context;
    
    public async Task<T?> FirstOrDefault(Expression<Func<T, bool>> expression)
    {
        return await _dbSet.AsNoTrackingWithIdentityResolution().FirstOrDefaultAsync(expression);
    }
    
    public async Task<bool> Any(Expression<Func<T, bool>> expression)
    {
        return await _dbSet.AnyAsync(expression);
    }
    
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
            Context.Dispose();
        }

        _isDisposed = true;
    }
    
    ~Repository()
    {
        Dispose(false);
    }
}