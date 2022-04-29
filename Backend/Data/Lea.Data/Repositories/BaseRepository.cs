using Lea.Data.Common;
using Lea.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Lea.Data.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : LeaEntity
{
    protected readonly LeaDbContext context;

    public BaseRepository(LeaDbContext context) 
        => this.context = context;

    public virtual async Task<T> GetByIdAsync(Guid id)
        => await context.Set<T>().FindAsync(id);

    public virtual async Task CreateAsync(T entity)
    {
        context.Set<T>().Add(entity);
        await context.SaveChangesAsync();
    }

    public virtual async Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>> filter)
    {
        var set = context.Set<T>().AsQueryable();

        if (filter is not null)
        {
            set = set.Where(filter);
        }

        return await set.ToListAsync();
    }

    public virtual async Task UpdateAsync(T entity)
    {
        var dbEntity = await GetByIdAsync(entity.Id);

        if (dbEntity is null)
        {
            throw new ArgumentException($"There is no such {typeof(T)} with id: {entity.Id}");
        }

        context.Entry(dbEntity).CurrentValues.SetValues(entity);

        await context.SaveChangesAsync();
    }

    public virtual async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);

        if (entity is null)
        {
            throw new ArgumentException($"There is no such {typeof(T)} with id: {id}");
        }

        context.Set<T>().Remove(entity);

        await context.SaveChangesAsync();
    }
}
