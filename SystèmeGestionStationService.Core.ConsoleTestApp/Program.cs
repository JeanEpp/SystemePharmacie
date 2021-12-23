using System;
using SystèmePharmacie.Core.Entities;
using SystèmePharmacie.Infrastructure;

namespace SystèmePharmacie.Core.ConsoleTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static void Test1()
        {
            var context = new SystèmePharmacieContext();
            Patient client1 = new Patient("01234567", "charles", "leroy", "4 rue des sapins Québec Québec Canada", "+1 123 456 7890", DateTime.Now);
            context.Add(client1);
            context.SaveChanges();
            Pharmacien pharmacien = new Pharmacien("jacques1", "motdepasse");
            context.Add(pharmacien);
            context.SaveChanges();
            Medicament medicament = new Medicament("1324", "xanax", ManiereLivraison.Gellule, "Armoire 1 tiroir 4", new Medicament.Posologie(3, 2), 50, 10.99);
            context.Add(medicament);
            context.SaveChanges();
            Medecin medecin = new Medecin("2413", "michele", "laroche", "12 avenue des coquelicots Montréal Quebec Canada", "+1 987 654 3210");
            context.Add(medecin);
            context.SaveChanges();
        }
    }
}
