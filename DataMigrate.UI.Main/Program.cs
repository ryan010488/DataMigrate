using System.Configuration;
using DataMigrate.Domain.Interfaces;
using DataMigrate.Domain.Interfaces.Repositories;
using DataMigrate.Domain.Interfaces.Services;
using DataMigrate.Infrastructure.Services;
using FiberStatus.Domain.Entities.Data;
using FiberStatus.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DataMigrate.UI.Main
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //ApplicationConfiguration.Initialize();
            //Application.Run(new frmImport());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    //services.AddDbContextPool<AppDbContext>(options => options.UseSqlite("DataMigrate.db"));
                    //services.AddTransient<DbContext, AppDbContext>();

                    //services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("TaskMngtSystemDB"));
                    services.AddDbContext<AppDbContext>(options => options.UseSqlite(""));

                    // Register your services here
                    services.AddTransient<IPatientRepository, PatientRepository>();
                    services.AddTransient<ITreatmentRepository, TreatmentRepository>();
                    services.AddTransient<IInvoiceRepository, InvoiceRepository>();
                    services.AddTransient<IPatientService, PatientService>();
                    services.AddTransient<ITreatmentService, TreatmentService>();
                    services.AddTransient<frmImport>(); // Register your main form
                    // ... other services
                })
                .Build();

            // Resolve the main form and run the application
            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                var mainForm = services.GetRequiredService<frmImport>();
                Application.Run(mainForm);
            }
        }

    }

}