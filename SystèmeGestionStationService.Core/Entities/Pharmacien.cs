using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystèmePharmacie.SharedKernel;
using SystèmePharmacie.SharedKernel.Interfaces;

namespace SystèmePharmacie.Core.Entities
{
    public class Pharmacien : BaseEntity, IAggregateRoot
    {
        public string nomConnexion { get; set; }
        public string motDePasse { get; set; }

        public Pharmacien()
        {

        }

        public Pharmacien(string nomConnexion, string motDePasse)
        {
            this.nomConnexion = nomConnexion;
            this.motDePasse = motDePasse;
        }
    }
}
