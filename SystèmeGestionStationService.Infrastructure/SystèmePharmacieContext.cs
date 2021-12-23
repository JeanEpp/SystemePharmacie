using Microsoft.EntityFrameworkCore;
using System;
using SystèmePharmacie.Core.Entities;

namespace SystèmePharmacie.Infrastructure
{
    public class SystèmePharmacieContext : DbContext
    {
        public DbSet<Medecin> Medecins { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Paiement> Paiements { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Pharmacie> Pharmacies { get; set; }
        public DbSet<Pharmacien> Pharmaciens { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<RuptureDeStock> RuptureDeStocks { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<TransactionVente> transactionVentes { get; set; }

        public SystèmePharmacieContext(DbContextOptions options)
            : base(options)
        {
        }

        public SystèmePharmacieContext() : base(new
          DbContextOptionsBuilder<SystèmePharmacieContext>()

          .UseSqlServer(@"Server=.;Database=SystèmePharmacieDB;    
                 Trusted_Connection=True;")
          .Options)
        { }

    }
}
