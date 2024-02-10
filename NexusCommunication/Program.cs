using Microsoft.EntityFrameworkCore;

using NexusCommunication.Data;

namespace NexusCommunication;

public static class Program
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        #region Database

        builder.Services.AddControllersWithViews();
        string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        if (connectionString == null)
        {
            throw new Exception($"Couldn't find a connection string for: ${connectionString}");
        }

        builder.Services.AddDbContext<ApplicationDbContext>(option =>
            option.UseSqlServer(connectionString));

        #endregion

        #region Session

        builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        builder.Services.AddDistributedMemoryCache();
        builder.Services.AddSession(options =>
        {
            options.IdleTimeout = TimeSpan.FromDays(30);
            options.Cookie.HttpOnly = true;
            options.Cookie.IsEssential = true;
        });

        #endregion


        WebApplication app = builder.Build();

        #region Extensions

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();
        app.MapControllerRoute(
            "default",
            "{controller=Home}/{action=Index}/{id?}"
        );
        app.MapControllerRoute(
            "areas",
            "{area:exists}/{controller=Home}/{action=Index}/{id?}"
        );

        #endregion

        app.Run();
    }
}