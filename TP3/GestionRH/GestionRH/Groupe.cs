using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRH
{
    internal class Groupe
    {
        private string nom;
        private List<Etudiant> etudiants;

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public List<Etudiant> Etudiants
        {
            get { return etudiants; }
            set { etudiants = value; }
        }
        public Groupe(string nom)
        {
            this.nom = nom;
            etudiants = new List<Etudiant>();
        }

        public void Ajouter_etudiant(Etudiant e)
        {
            etudiants.Add(e);
        }

        public void Afficher_grp()
        {
            Console.WriteLine("Nom du groupe : " + nom);
            Console.WriteLine("Etudiants du groupe : ");
            foreach (var etu in etudiants)
            {
                Console.WriteLine($" - {etu.Nom} {etu.Prenom} (Niveau: {etu.Niveau}, Moyenne: {etu.Moyenne})");
            }

        }
    }
}
