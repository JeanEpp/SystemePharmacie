using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystèmePharmacie.SharedKernel;
using SystèmePharmacie.SharedKernel.Interfaces;

namespace SystèmePharmacie.Core.Entities
{
    public class Prescription : BaseEntity, IAggregateRoot
    {
        public string numero { get; set; }
        public DateTime date { get; set; }
        public string copiePrescription { get; set; }
        public Medecin medecin { get; set; }
        public Patient patient { get; set; }
        public Pharmacie pharmacie { get; set; }
        public List<LignePrescription> prescriptions { get; set; }

        public class LignePrescription
        {
            public string numero { get; set; }
            public string nom { get; set; }
            public Medicament.Posologie posologie { get; set; }
            public int quantité { get; set; }
            public int nombreRenouvellement { get; set; }
            public int nombreRenouvellementRestants { get; set; }

            public List<TransactionVente> transactionVentes { get; set; } = new List<TransactionVente>();

            public LignePrescription()
            {

            }

            public LignePrescription(string numero, string nom, int quantité, int nombreRenouvellement, int nombreRenouvellementRestant)
            {
                this.numero = numero;
                this.nom = nom;
                this.quantité = quantité;
                this.nombreRenouvellement = nombreRenouvellement;
                this.nombreRenouvellementRestants = nombreRenouvellementRestant;
            }
            public void AddTransactionVente(TransactionVente transactionVente)
            {
                transactionVentes.Add(transactionVente);
            }
            public void RemoveTransactionVente(TransactionVente transactionVente)
            {
                transactionVentes.Remove(transactionVente);
            }
        }

        public Prescription()
        {

        }

        public Prescription(string numero, DateTime date, string copiePrescription)
        {
            this.numero = numero;
            this.date = date;
            this.copiePrescription = copiePrescription;
        }
    }
}
