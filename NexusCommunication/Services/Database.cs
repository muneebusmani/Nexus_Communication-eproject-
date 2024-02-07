using Microsoft.EntityFrameworkCore;

using NexusCommunication.Data;

namespace NexusCommunication.Services;

public static class Database
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        string? connectionString = configuration.GetConnectionString("DefaultConnection");
        if (connectionString == null)
        {
            throw new Exception($"Couldn't find a connection string for: ${connectionString}");
        }

        services.AddDbContext<ApplicationDbContext>(option =>
            option.UseSqlServer(connectionString));
        return services;
    }
}