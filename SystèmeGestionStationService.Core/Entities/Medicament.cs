using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystèmePharmacie.SharedKernel;
using SystèmePharmacie.SharedKernel.Interfaces;

namespace SystèmePharmacie.Core.Entities
{
    public class Medicament : BaseEntity, IAggregateRoot
    {
        public class Posologie
        {
            public int nombreUnitesParJour { get; set; }
            public int nombreJours { get; set; }

            public Posologie()
            {

            }

            public Posologie(int nombreUnitesParJour, int nombreJours)
            {
                this.nombreJours = nombreJours;
                this.nombreUnitesParJour = nombreUnitesParJour;
            }
        }

        public string numero { get; set; }
        public string nom { get; set; }
        public ManiereLivraison maniereLivraison { get; set; }
        public string endroit { get; set; }
        public Posologie posologie { get; set; }
        public int quantiteStock { get; set; }
        public double prixVente { get; set; }
        public List<RuptureDeStock> rupturesDeStock { get; private set; } = new List<RuptureDeStock>(); 

        public Medicament()
        {

        }

        public Medicament(string numero, string nom, ManiereLivraison maniereLivraison, string endroit, Posologie posologie, int quantiteStock, double prixVente)
        {
            this.numero = numero;
            this.nom = nom;
            this.maniereLivraison = maniereLivraison;
            this.endroit = endroit;
            this.posologie = posologie;
            this.quantiteStock = quantiteStock;
            this.prixVente = prixVente;
        }

        public void AddRupturesDeStock(RuptureDeStock ruptureDeStock)
        {
            rupturesDeStock.Add(ruptureDeStock);
        }
        public void RemoveRuptureDeStock(RuptureDeStock ruptureDeStock)
        {
            rupturesDeStock.Remove(ruptureDeStock);
        }
    }
}
