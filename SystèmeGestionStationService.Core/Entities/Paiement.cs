using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystèmePharmacie.SharedKernel;
using SystèmePharmacie.SharedKernel.Interfaces;

namespace SystèmePharmacie.Core.Entities
{
    public class Paiement : BaseEntity, IAggregateRoot
    {
        public string numero { get; set; }
        public DateTime date { get; set; }
        public double montant { get; set; }
        public TypePaiement type { get; set; }
        public int paiementId { get; set; }
        public Paiement paiement { get; private set; }

        public Paiement()
        {

        }

        public Paiement(string numero, DateTime date, double montant, TypePaiement type)
        {
            this.numero = numero;
            this.date = date;
            this.montant = montant;
            this.type = type;
        }
    }
}
