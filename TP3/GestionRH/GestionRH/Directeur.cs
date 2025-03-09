using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRH
{
    internal class Directeur : Personnel
    {
        private static Directeur directeur;
        private Directeur(string code, string nom, string prenom, string bureau, double salaire, double prime) : base(code, nom, prenom, bureau, salaire, prime)
        {

        }
        public static Directeur getDirecteur(string code, string nom, string prenom, string bureau, double salaire, double prime)
        {
            if (directeur == null)
            {
                directeur = new Directeur(code, nom, prenom, bureau, salaire, prime);
            }
            return directeur;
        }
        override
        public double calculerSalaire()
        {
            return Salaire + Prime;
        }
    }
}
