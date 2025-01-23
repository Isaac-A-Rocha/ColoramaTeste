using System.Linq.Expressions;
using Colorama.Domain.Contracts.Interfaces;

namespace Colorama.Domain.Contracts.Repositories;

public interface IRepository<T> : IDisposable where T : IAggregateRoot
{
    IUnitOfWork UnitOfWork { get; }
    Task<T?> FirstOrDefault(Expression<Func<T, bool>> expression);
    Task<bool> Any(Expression<Func<T, bool>> expression);
}