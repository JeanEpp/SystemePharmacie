using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystèmePharmacie.SharedKernel;
using SystèmePharmacie.SharedKernel.Interfaces;

namespace SystèmePharmacie.Core.Entities
{
    public class TransactionVente : BaseEntity, IAggregateRoot
    {
        public string numero { get; set; }
        public DateTime date { get; set; }
        public double montantTotal { get; set; }

        public TransactionVente transactionVente { get; set; }

        public class LigneTransactionVente
        {
            public string numero { get; set; }
            public double montantLigne { get; set; }

            public LigneTransactionVente()
            {

            }

            public LigneTransactionVente(string numero, double montantLigne)
            {
                this.numero = numero;
                this.montantLigne = montantLigne;
            }
        }

        public TransactionVente()
        {

        }

        public TransactionVente(string numero, DateTime date, double montantTotal)
        {
            this.numero = numero;
            this.date = date;
            this.montantTotal = montantTotal;
        }
    }
}
