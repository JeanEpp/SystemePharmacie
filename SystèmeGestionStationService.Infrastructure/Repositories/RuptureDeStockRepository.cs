using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystèmePharmacie.Core.Entities;
using SystèmePharmacie.Core.Interfaces;

namespace SystèmePharmacie.Infrastructure.Repositories
{
    public class RuptureDeStockRepository : EfRepository<RuptureDeStock>, IRuptureDeStock
    {
        public RuptureDeStockRepository(SystèmePharmacieContext systèmePharmacieContext) : base(systèmePharmacieContext)
        {
        }
    }
}
