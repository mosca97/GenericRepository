using GenericRepository.Domain.Core;

namespace GenericRepository.Business;
internal sealed class CustomerManager(ICustomerRepository repository)
    : GenericManager<int, CustomerDto>(repository), ICustomerManager
{
}
