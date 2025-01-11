namespace GenericRepository.Domain.Core;

public interface IGenericRepository<TKey, T>
{
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task<IQueryable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(TKey id);
}