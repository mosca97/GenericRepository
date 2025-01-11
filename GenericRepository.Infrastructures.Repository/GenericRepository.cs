using GenericRepository.Domain.Core;
using Mapster;

namespace GenericRepository.Infrastructures.Repository;

internal abstract class GenericRepository<Tkey, TDomain, TDatabase> 
    : IGenericRepository<Tkey, TDomain>
    where TDomain : BaseDto<Tkey>
{
    private readonly static Dictionary<Tkey, TDatabase> _database = [];

    public async Task AddAsync(TDomain entity)
    {
        var databaseModel = entity.Adapt<TDatabase>();

        _database.Add(entity.Id, databaseModel);

        await Task.CompletedTask;
    }

    public async Task UpdateAsync(TDomain entity)
    {
        var databaseModel = entity.Adapt<TDatabase>();

        _database.Add(entity.Id, databaseModel);

        await Task.CompletedTask;
    }

    public Task<IQueryable<TDomain>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TDomain?> GetByIdAsync(Tkey id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Tkey id)
    {
        throw new NotImplementedException();
    }
}
