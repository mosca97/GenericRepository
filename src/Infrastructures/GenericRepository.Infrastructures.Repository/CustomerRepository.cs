using GenericRepository.Domain.Core;

namespace GenericRepository.Infrastructures.Repository;
internal sealed class CustomerRepository(ApplicationDbContext context)
        : GenericRepository<int, CustomerDto, CustomerEntity>(context), ICustomerRepository
{
    public Task GetSpecificQuery()
    {
        throw new NotImplementedException();
    }
}

internal class CustomerEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsAvailable { get; set; } = true;
}