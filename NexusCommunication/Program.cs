using NexusCommunication.Services;

namespace NexusCommunication;

public static class Program
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        #region Services

        builder.Services.AddControllersWithViews();
        builder.Services.AddDatabase(builder.Configuration);
        builder.Services.AddRepositories();
        builder.Services.ConfigureSession();

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

        #endregion

        app.Run();
    }
}