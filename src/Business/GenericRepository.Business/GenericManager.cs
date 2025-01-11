using GenericRepository.Domain.Core;

namespace GenericRepository.Business;

internal abstract class GenericManager<Tkey, T>(IGenericRepository<Tkey, T> repository)
    : IGenericManager<Tkey, T>
{
    public Task AddAsync(T entity)
        => repository.AddAsync(entity);

    public IQueryable<T> GetAll()
        => repository.GetAll();

    public Task<T?> GetByIdAsync(Tkey id)
        => repository.GetByIdAsync(id);

    public Task UpdateAsync(T entity)
        => repository.UpdateAsync(entity);
}
