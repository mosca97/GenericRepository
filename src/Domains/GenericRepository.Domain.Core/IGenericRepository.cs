namespace GenericRepository.Domain.Core;

public interface IGenericRepository<TKey, T>
{
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    IQueryable<T> GetAll();
    Task<T?> GetByIdAsync(TKey id);
}