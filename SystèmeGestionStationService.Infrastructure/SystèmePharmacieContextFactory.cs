using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace SystèmePharmacie.Infrastructure
{
    public class SystèmePharmacieContextFactory : IDesignTimeDbContextFactory<SystèmePharmacieContext>
    {
        public SystèmePharmacieContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SystèmePharmacieContext>();
            optionsBuilder.UseSqlServer(@"Server=.;Database=SystèmePharmacieDB;Trusted_Connection=True;");

            return new SystèmePharmacieContext(optionsBuilder.Options);
        }
    }
}
