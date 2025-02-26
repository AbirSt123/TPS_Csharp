using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2EX1
{
    internal class Directeur
    {
        private static Directeur instance;
        private GestionEmployes gestionEmployes;

        private Directeur()
        {
            gestionEmployes = new GestionEmployes();
        }

        public static Directeur GetInstance()
        {
            if (instance == null)
            {
                instance = new Directeur();
            }
            return instance;
        }

        public void SetGestionEmployes(GestionEmployes gestion)
        {
            this.gestionEmployes = gestion;
        }
        public double GetSalaireTotal()
        {
            return gestionEmployes.calculerSalaireTotal();
        }

        public double GetSalaireMoyen()
        {
            return gestionEmployes.CalculerSalaireMoyen();
        }

        public void AfficherInformationsEntreprise()
        {
            Console.WriteLine("\nInformations de l'entreprise:");
            Console.WriteLine($"Salaire total de l'entreprise: {gestionEmployes.calculerSalaireTotal():C}");
            Console.WriteLine($"Salaire moyen des employés: {gestionEmployes.CalculerSalaireMoyen():C}");
        }
        public List<Employee> GetEmployes()
        {
            return gestionEmployes.GetEmployes();
        }
    }
}
