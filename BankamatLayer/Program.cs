using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Services;
using DataAccessLayer.Data;
using BankamatLayer.Bankomats;

namespace BankamatLayer
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddSignalR();
            builder.WebHost.UseWebRoot("wwwroot");
            builder.WebHost.UseUrls("https://localhost:1808");

            var app = builder.Build();
            app.MapHub<NetworkHub>("/network");
            Task.Run(() => app.Run());


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();

            var form1 = serviceProvider.GetRequiredService<Bankamant>();
            Application.Run(form1);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            const string connectionString = "Host=localhost;Port=5432;Database=Navbat;Username=postgres;Password=1234";

            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(connectionString, o => o.EnableRetryOnFailure()), ServiceLifetime.Transient, ServiceLifetime.Transient);

            services.AddTransient<IUserInterface, UserService>();
            services.AddTransient<Bankamant>();

        }
    }
}
