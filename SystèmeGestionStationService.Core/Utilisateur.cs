using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystèmePharmacie.SharedKernel;
using SystèmePharmacie.SharedKernel.Interfaces;

namespace SystèmePharmacie.Core.Entities
{
    public class Utilisateur : BaseEntity, IAggregateRoot
    {
        public string nomConnexion { get; set; }
        public string motDePasse { get; set; }
        public virtual List<Session> sessions { get; private set; } = new List<Session>();

        public Utilisateur()
        {

        }

        public Utilisateur(string nomConnexion, string motDePasse)
        {
            this.nomConnexion = nomConnexion;
            this.motDePasse = motDePasse;
        }

        public void AddSession(Session session)
        {
            sessions.Add(session);
        }
        public void RemoveSession(Session session)
        {
            sessions.Remove(session);
        }
    }
}
