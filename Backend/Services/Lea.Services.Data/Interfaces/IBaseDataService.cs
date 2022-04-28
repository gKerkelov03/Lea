using Lea.Data.Common;
using System.Linq.Expressions;

namespace Lea.Services.Data.Interfaces;

public interface IBaseDataService<TEntity, TServiceModel>
    where TEntity : LeaEntity
    where TServiceModel : class    
{
    Task Create(TServiceModel model);

    Task Delete(Guid id);

    Task<TServiceModel> GetByIdAsync(Guid id);

    Task<TEntity> OnBeforeCreate(TServiceModel model);

    Task<TEntity> OnBeforeUpdate(TServiceModel model);

    Task Update(TServiceModel model);

    Task<List<TServiceModel>> GetAllAsync(Expression<Func<TServiceModel, bool>> filter);
}
