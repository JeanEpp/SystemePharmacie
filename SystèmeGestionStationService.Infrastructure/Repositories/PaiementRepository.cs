using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystèmePharmacie.Core.Entities;
using SystèmePharmacie.Core.Interfaces;

namespace SystèmePharmacie.Infrastructure.Repositories
{
    public class PaiementRepository : EfRepository<Paiement>, IPaiement
    {
        public PaiementRepository(SystèmePharmacieContext systèmePharmacieContext) : base(systèmePharmacieContext)
        {
        }
    }
}
