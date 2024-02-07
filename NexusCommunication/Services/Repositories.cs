using NexusCommunication.Interfaces;
using NexusCommunication.Repositories;

namespace NexusCommunication.Services;

public static class Repositories
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddTransient<ICustomerRepository, CustomerRepository>();
        return services;
    }
}