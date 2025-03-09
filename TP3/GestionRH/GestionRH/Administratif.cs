using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRH
{
    internal class Administratif : Personnel
    {
        public Administratif(string code, string nom, string prenom, string bureau, double salaire, double prime) : base(code, nom, prenom, bureau, salaire, prime)
        {

        }

        override
        public double calculerSalaire()
        {
            return Salaire;
        }
    }
}
