using System;
using System.Windows.Forms;
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
            // 1) Build the Host (reads appsettings.json & sets up DI container)
            var host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((ctx, cfg) =>
                {
                    cfg.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((ctx, services) =>
                {
                    // 2) Register DbContext
                    services.AddDbContext<GarageDbContext>(options =>
                        options.UseSqlServer(
                            ctx.Configuration.GetConnectionString("DefaultConnection")
                        )
                    );

                    services.AddScoped<ICarService, CarService>();
                    services.AddScoped<IMechanicService, MechanicService>();
                    services.AddScoped<IServiceRecordService, ServiceRecordService>();
                    services.AddScoped<IPdfExportService ,PdfExportService>();

                    // 3) Register your main form so it can get DI-injected
                    services.AddScoped<Form1>();
                })
                .Build();

            QuestPDF.Settings.License = LicenseType.Community;
            // 4) Initialize WinForms and run the main form from the DI container
            ApplicationConfiguration.Initialize();
            using var scope = host.Services.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<Form1>();
            Application.Run(form);
        }
    }
}
