using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystèmePharmacie.SharedKernel;
using SystèmePharmacie.SharedKernel.Interfaces;

namespace SystèmePharmacie.Core.Entities
{
    public class Session : BaseEntity, IAggregateRoot
    {
        public DateTime dateConnexion { get; set; }
        public DateTime dateDeconnexion { get; set; }
        public Prescription prescription { get; set; }
        public TransactionVente transaction { get; set; }

        public Session()
        {
            this.dateConnexion = DateTime.Now;
        }
    }
}
