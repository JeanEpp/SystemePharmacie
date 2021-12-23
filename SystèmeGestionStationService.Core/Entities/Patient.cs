using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystèmePharmacie.SharedKernel;
using SystèmePharmacie.SharedKernel.Interfaces;

namespace SystèmePharmacie.Core.Entities
{
    public class Patient : BaseEntity, IAggregateRoot
    {
        public string numeroAssuranceMaladie { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string adresse { get; set; }
        public string numeroDeTelephone { get; set; }
        public DateTime dateDeNaissance { get; set; }
        public List<Prescription> prescriptions { get; private set; } = new List<Prescription>();

        public Patient()
        {

        }

        public Patient(string numeroAssuranceMaladie, string nom, string prenom, string adresse, string numeroDeTelephone, DateTime dateDeNaissance)
        {
            this.numeroAssuranceMaladie = numeroAssuranceMaladie;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.numeroDeTelephone = numeroDeTelephone;
            this.dateDeNaissance = dateDeNaissance;
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
