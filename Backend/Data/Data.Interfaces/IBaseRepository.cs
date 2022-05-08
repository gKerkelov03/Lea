using Data.Common;
using System.Linq.Expressions;

namespace Data.Interfaces;

public interface IBaseRepository<T> where T : LeaEntity
{
    Task CreateAsync(T entity);

    Task DeleteAsync(Guid id);

    Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>> filter);

    Task<T> GetByIdAsync(Guid id);

    Task UpdateAsync(T entity);
}
