using System.Linq.Expressions;

namespace Repository.Contracts;
public interface IRepositoryBase<T>
{
    protected IQueryable<T> FindAll(bool trackChanges);
    protected T? FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
    protected void Create(T entity);
    protected void Delete(T entity);
    protected void Update(T entity);
}