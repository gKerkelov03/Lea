using AutoMapper;
using Lea.Data.Common;
using Lea.Data.Interfaces;
using Lea.Services.Interfaces.Data;
using System.Linq.Expressions;

namespace Lea.Services.Data;

public class BaseDataService<TEntity, TServiceModel, TRepository> : IBaseDataService<TEntity, TServiceModel> 
    where TEntity : LeaEntity
    where TServiceModel : class    
    where TRepository : IBaseRepository<TEntity>
{
    protected readonly TRepository _repository;
    protected readonly IMapper mapper;

    public BaseDataService(TRepository repository, IMapper mapper)
    {
        _repository = repository;
        this.mapper = mapper;
    }
    
    public virtual async Task<TEntity> OnBeforeCreate(TServiceModel model) 
        => await Task.FromResult(mapper.Map<TEntity>(model));

    public virtual async Task<TEntity> OnBeforeUpdate(TServiceModel model) 
        => await Task.FromResult(mapper.Map<TEntity>(model));    

    public virtual async Task Delete(Guid id) 
        => await _repository.DeleteAsync(id);
    
    public virtual async Task Create(TServiceModel model)
        => await _repository.CreateAsync(await OnBeforeCreate(model));
    

    public async virtual Task Update(TServiceModel model)
        => await _repository.UpdateAsync(await OnBeforeUpdate(model));
    

    public virtual async Task<TServiceModel> GetByIdAsync(Guid id)
        => mapper.Map<TServiceModel>(await _repository.GetByIdAsync(id));
    

    public virtual async Task<List<TServiceModel>> GetAllAsync(Expression<Func<TServiceModel, bool>> filter)
    {
        var expression = mapper.Map<Expression<Func<TEntity, bool>>>(filter);
        var result = await _repository.GetAllAsync(expression);

        return mapper.Map<List<TServiceModel>>(result);
    }
}
