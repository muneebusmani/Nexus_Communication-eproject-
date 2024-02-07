namespace NexusCommunication.Services;

public static class Session
{
    public static IServiceCollection ConfigureSession(this IServiceCollection services)
    {
        services.AddDistributedMemoryCache();
        services.AddSession(options =>
        {
            options.IdleTimeout = TimeSpan.FromSeconds(10);
            options.Cookie.HttpOnly = true;
            options.Cookie.IsEssential = true;
        });
        return services;
    }
}