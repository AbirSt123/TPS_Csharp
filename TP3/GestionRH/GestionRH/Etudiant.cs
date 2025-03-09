using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRH
{
    internal class Etudiant : Personne
    {
        private string niveau;
        private float moyenne;

        public string Niveau
        {
            get { return niveau; }
            set { niveau = value; }
        }
        public float Moyenne
        {
            get { return moyenne; }
            set { moyenne = value; }
        }

        public Etudiant(string niveau, float moyenne, string code, string nom, string prenom) : base(code, nom, prenom)
        {
            this.niveau = niveau;
            this.moyenne = moyenne;
        }
        public void Afficher_etd()
        {
            Console.WriteLine("Code : " + Code + "Nom : " + Nom + "Prénom: " + Prenom + "Niveau: " + niveau + "Moyenne: " + moyenne);
        }
    }
}
