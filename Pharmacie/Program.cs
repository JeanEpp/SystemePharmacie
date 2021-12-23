using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystèmePharmacie.Core.Interfaces;
using SystèmePharmacie.Infrastructure;
using SystèmePharmacie.Infrastructure.Repositories;

namespace SystèmePharmacie.Pharmacie
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder()
             .ConfigureServices((hostContext, services) =>
             {
                 services.AddDbContext<SystèmePharmacieContext>(options => options.UseSqlServer(@"Server=.;Database=SystèmePharmacie;Trusted_Connection=True;"));
                 services.AddSingleton<EcranPrincipale>();
                 services.AddLogging(configure => configure.AddConsole());
                 services.AddScoped<IMedecin, MedecinRepository>();
                 services.AddScoped<IMedicament, MedicamentRepository>();
                 services.AddScoped<IPaiement, PaiementRepository>();
                 services.AddScoped<IPatient, PatientRepository>();
                 services.AddScoped<IPharmacie, PharmacieRepository>();
                 services.AddScoped<IPharmacien, PharmacienRepository>();
                 services.AddScoped<IPrescription, PrescriptionRepository>();
                 services.AddScoped<IRuptureDeStock, RuptureDeStockRepository>();
                 services.AddScoped<ISession, SessionRepository>();
                 services.AddScoped<ITransactionVente, TransactionVenteRepository>();

             });

            var host = builder.Build();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var forms = services.GetRequiredService<EcranPrincipale>();
                    Application.Run(forms);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}

