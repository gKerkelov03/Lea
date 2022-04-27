using Lea.Data.Common;
using System.Linq.Expressions;

namespace Lea.Services.Data.Contracts;

public interface IBaseDataService<TEntity, TBindingModel>
    where TEntity : LeaEntity
    where TBindingModel : class
{
    Task Create(TBindingModel model);

    Task Delete(Guid id);

    ValueTask<TBindingModel> GetByIdAsync(Guid id);

    Task<TEntity> OnBeforeCreate(TBindingModel model);

    Task<TEntity> OnBeforeUpdate(TBindingModel model);

    Task Update(TBindingModel model);

    Task<List<TBindingModel>> GetAllAsync(Expression<Func<TBindingModel, bool>> filter);
}
