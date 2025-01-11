using GenericRepository.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Infrastructures.Repository;
internal sealed class CustomerRepository : GenericRepository<string, CustomerDto, CustomerEntity>, ICustomerRepository
{
    public CustomerRepository()
    {
    }

    public Task GetSpecificQuery()
    {
        throw new NotImplementedException();
    }
}



internal class CustomerEntity
{
    public required string Id { get; set; }
    public required string Name { get; set; }

    public bool IsAvailable { get; set; } = true;
}