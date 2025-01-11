namespace GenericRepository.Domain.Core;
public class CustomerDto : BaseDto<int>
{
    public required string Name { get; set; }
}

public class BaseDto<TKey>
{
    public TKey Id { get; set; }
}