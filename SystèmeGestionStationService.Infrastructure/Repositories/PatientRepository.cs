using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystèmePharmacie.Core.Entities;
using SystèmePharmacie.Core.Interfaces;

namespace SystèmePharmacie.Infrastructure.Repositories
{
    public class PatientRepository : EfRepository<Patient>, IPatient
    {
        public PatientRepository(SystèmePharmacieContext systèmePharmacieContext) : base(systèmePharmacieContext)
        {
        }
    }
}
