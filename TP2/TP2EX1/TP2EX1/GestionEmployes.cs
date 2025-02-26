using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TP2EX1
{
    internal class GestionEmployes
    {
        private List<Employee> employes = new List<Employee>();
        public void AjouterEmploye(Employee employee)
        {
            employes.Add(employee);

        }
        public void Supprimer(Employee employee)
        {
            employes.Remove(employee);
        }

        public double calculerSalaireTotal()
        {
            double total = 0;
            foreach(Employee emp in employes)
            {
                total += emp.Salaire;
                
            }
            return total;
        }
        public double CalculerSalaireMoyen()
        {
            if (employes.Count == 0)
                return 0;
            double totalSalaire = calculerSalaireTotal();
            double salaireMoyen = totalSalaire / employes.Count;

            return salaireMoyen;
        }
        public List<Employee> GetEmployes()
        {
            return employes;
        }


    }
}
