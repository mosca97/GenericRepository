namespace GenericRepository.Domain.Core;
public interface ICustomerRepository : IGenericRepository<int, CustomerDto>
{
    public Task GetSpecificQuery();
}
