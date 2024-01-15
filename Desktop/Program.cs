using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Services;
using DataAccessLayer.Data;
using Desktop.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace Desktop;

internal static class Program
{

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var services = new ServiceCollection();

        ConfigureServices(services);

        var serviceProvider = services.BuildServiceProvider();

        var form1 = serviceProvider.GetRequiredService<Register>();
        Application.Run(form1);
    }
    private static void ConfigureServices(IServiceCollection services)
    {
        const string connectionString = "Host=192.168.35.187;Port=5432;Database=Navbat;Username=postgres;Password=1234";

        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(connectionString, o => o.EnableRetryOnFailure()), ServiceLifetime.Transient, ServiceLifetime.Transient);

        services.AddTransient<IUserInterface, UserService>();

        services.AddScoped<Register>();
        services.AddScoped<Login>();
        services.AddScoped<ForgetPassword>();
        services.AddScoped<ResetPassword>();
        services.AddScoped<OTP>();
    }

}