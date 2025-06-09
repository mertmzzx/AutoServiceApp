using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using AutoService.Data;
using AutoService.Services;
using QuestPDF.Infrastructure;

namespace AutoService
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((ctx, cfg) =>
                {
                    cfg.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((ctx, services) =>
                {
                    services.AddDbContext<GarageDbContext>(options =>
                        options.UseSqlServer(
                            ctx.Configuration.GetConnectionString("DefaultConnection")
                        )
                    );

                    services.AddScoped<ICarService, CarService>();
                    services.AddScoped<IMechanicService, MechanicService>();
                    services.AddScoped<IServiceRecordService, ServiceRecordService>();
                    services.AddScoped<IExportService ,ExportService>();

                    services.AddScoped<MainForm>();
                })
                .Build();

            QuestPDF.Settings.License = LicenseType.Community;

            ApplicationConfiguration.Initialize();
            using var scope = host.Services.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<MainForm>();
            Application.Run(form);
        }
    }
}
