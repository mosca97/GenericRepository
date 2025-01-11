using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Domain.Core;
public interface ICustomerRepository : IGenericRepository<string, CustomerDto>
{
    public Task GetSpecificQuery();
}
