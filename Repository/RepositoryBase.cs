using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Repository.Contracts;

namespace Repository;
public abstract class RepositoryBase<T>(RepositoryContext context) : IRepositoryBase<T> where T : class, new()
{
    protected readonly RepositoryContext _context = context;

    public IQueryable<T> FindAll(bool trackChanges)
    {
        return trackChanges
        ? _context.Set<T>()
        : _context.Set<T>().AsNoTracking();
    }

    public T? FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
    {
        return trackChanges
        ? _context.Set<T>().Where(expression).SingleOrDefault()
        : _context.Set<T>().Where(expression).AsNoTracking().SingleOrDefault();
    }

    public void Create(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }
    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }
}