using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystèmePharmacie.SharedKernel;
using SystèmePharmacie.SharedKernel.Interfaces;

namespace SystèmePharmacie.Core.Entities
{
    public class Pharmacie : BaseEntity, IAggregateRoot
    {
        public string numero { get; set; }
        public string nom { get; set; }
        public string nomResponsable { get; set; }
        public string adresse { get; set; }
        public string numeroDeTelephone { get; set; }
        public List<Prescription> prescriptions { get; private set; } = new List<Prescription>();


        public Pharmacie()
        {

        }

        public Pharmacie(string numero, string nom, string nomResponsable, string adresse, string numeroDeTelephone)
        {
            this.numero = numero;
            this.adresse = adresse;
            this.nom = nom;
            this.nomResponsable = nomResponsable;
            this. numeroDeTelephone = numeroDeTelephone;
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
