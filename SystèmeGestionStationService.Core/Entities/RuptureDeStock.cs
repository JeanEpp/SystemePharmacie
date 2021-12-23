using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystèmePharmacie.SharedKernel;
using SystèmePharmacie.SharedKernel.Interfaces;

namespace SystèmePharmacie.Core.Entities
{
    public class RuptureDeStock : BaseEntity, IAggregateRoot
    {
        public DateTime date { get; set; }
        public int quantiteDemande { get; set; }
        public List<Prescription> prescriptions { get; private set; } = new List<Prescription>();

        public RuptureDeStock()
        {

        }

        public RuptureDeStock(DateTime date, int quantiteDemande)
        {
            this.date = date;
            this.quantiteDemande = quantiteDemande;
        }

        public void AddPrescription(Prescription prescription)
        {
            prescriptions.Add(prescription);
        }
        public void RemovePrescription(Prescription prescription)
        {
            prescriptions.Remove(prescription);
        }
    }
}
