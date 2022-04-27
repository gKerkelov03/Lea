using AutoMapper;
using Lea.Data.Common;
using Lea.Data.Repositories.Contracts;
using Lea.Services.Data.Contracts;
using System.Linq.Expressions;

namespace Lea.Services.Data;

public class BaseDataService<TEntity, TViewModel, TRepository> : IBaseDataService<TEntity, TViewModel> 
    where TEntity : LeaEntity
    where TViewModel : class
    where TRepository : IBaseRepository<TEntity>
{
    protected readonly TRepository _repository;
    protected readonly IMapper mapper;

    public BaseDataService(TRepository repository, IMapper mapper)
    {
        _repository = repository;
        this.mapper = mapper;
    }
    
    public virtual async Task<TEntity> OnBeforeCreate(TViewModel model) => mapper.Map<TEntity>(model);

    public virtual async Task<TEntity> OnBeforeUpdate(TViewModel model) => mapper.Map<TEntity>(model);    

    public virtual async Task Delete(Guid id) => await _repository.DeleteAsync(id);
    
    public virtual async Task Create(TViewModel model)
    {
        var entity = await OnBeforeCreate(model);
        await _repository.CreateAsync(entity);
    }


    public async virtual Task Update(TViewModel model)
    {
        var entity = await OnBeforeUpdate(model);
        await _repository.UpdateAsync(entity);
    }

    public virtual async ValueTask<TViewModel> GetByIdAsync(Guid id)
    {
        var entity = await _repository.GetByIdAsync(id);

        return mapper.Map<TViewModel>(entity);
    }

    public virtual async Task<List<TViewModel>> GetAllAsync(Expression<Func<TViewModel, bool>> filter)
    {
        var expression = mapper.Map<Expression<Func<TEntity, bool>>>(filter);
        var result = await _repository.GetAllAsync(expression);

        return mapper.Map<List<TViewModel>>(result);
    }
}
