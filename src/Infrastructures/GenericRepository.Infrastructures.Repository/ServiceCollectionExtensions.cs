using GenericRepository.Domain.Core;
using Microsoft.Extensions.DependencyInjection;

namespace GenericRepository.Infrastructures.Repository;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<IFavouriteRepository, FavouriteRepository>();

        services.AddDbContext<ApplicationDbContext>();

        return services;
    }
}
