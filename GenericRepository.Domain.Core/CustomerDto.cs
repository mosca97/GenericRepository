using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Domain.Core;
public class CustomerDto : BaseDto<string>
{
    public required string Name { get; set; }
}

public class BaseDto<TKey>
{
    public TKey Id { get; set; }
}