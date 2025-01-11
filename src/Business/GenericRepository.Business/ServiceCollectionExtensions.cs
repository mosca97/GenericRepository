using GenericRepository.Domain.Core;
using Microsoft.Extensions.DependencyInjection;

namespace GenericRepository.Business;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBusiness(this IServiceCollection services)
    {
        services.AddTransient<ICustomerManager, CustomerManager>();
        return services;
    }
}
