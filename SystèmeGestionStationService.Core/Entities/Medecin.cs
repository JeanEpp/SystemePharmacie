using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystèmePharmacie.SharedKernel;
using SystèmePharmacie.SharedKernel.Interfaces;

namespace SystèmePharmacie.Core.Entities
{
    public class Medecin : BaseEntity, IAggregateRoot
    {
        public string numero { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string adresse { get; set; }
        public string numeroDeTelephone { get; set; }

        public Medecin()
        {

        }

        public Medecin(string numero, string nom, string prenom, string adresse, string numeroDeTelephone)
        {
            this.numero = numero;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.numeroDeTelephone = numeroDeTelephone;
        }
    }
}
