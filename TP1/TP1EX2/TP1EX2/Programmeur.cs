using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1EX2
{
    class Programmeur
    {
        public string Nom { get; set; }
        public string Bureau { get; set; }
        public List<ConsommationCafe> Consommations { get; set; }

        public Programmeur(string nom, string bureau)
        {
            Nom = nom;
            Bureau = bureau;
            Consommations = new List<ConsommationCafe>();
        }

        public void AjouterConsommation(int semaine, int tasses)
        {
            Consommations.Add(new ConsommationCafe(semaine, tasses));
        }

        public int GetConsommationSemaine(int semaine)
        {
            ConsommationCafe consommation = Consommations.Find(c => c.Semaine == semaine);
            return consommation != null ? consommation.Tasses : 0;
        }

        public void Afficher()
        {
            Console.WriteLine("Nom: " + Nom + ", Bureau: " + Bureau);
        }
    }
}
