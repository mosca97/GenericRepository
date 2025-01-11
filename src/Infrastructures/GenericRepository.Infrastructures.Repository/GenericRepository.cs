using GenericRepository.Domain.Core;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Infrastructures.Repository;

internal abstract class GenericRepository<Tkey, TDomain, TDatabase>(DbContext context)
    : IGenericRepository<Tkey, TDomain>
    where TDomain : BaseDto<Tkey>
    where TDatabase : class, new()
{
    public async Task AddAsync(TDomain entity)
    {
        var databaseModel = entity.Adapt<TDatabase>();

        await context.Set<TDatabase>().AddAsync(databaseModel);

        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TDomain entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TDomain> GetAll()
    {
        return (context.Set<TDatabase>().AsQueryable()).Select(x => x.Adapt<TDomain>());
    }

    public async Task<TDomain?> GetByIdAsync(Tkey id)
    {
        var item = await context.Set<TDatabase>().FindAsync(id);

        if (item is null)
            return null;

        return item.Adapt<TDomain>();
    }

    public Task DeleteAsync(Tkey id)
    {
        throw new NotImplementedException();
    }
}
