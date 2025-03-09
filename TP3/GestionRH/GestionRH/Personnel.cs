using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRH
{
    internal abstract class Personnel : Personne
    {
        private string bureau;
        private double salaire;
        private double prime;

        public string Bureau
        {
            get { return bureau; }
            set { bureau = value; }
        }

        public double Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }

        public double Prime
        {
            get { return prime; }
            set { prime = value; }
        }
        public Personnel(string code, string nom, string prenom, string bureau, double salaire, double prime) : base(code, nom, prenom)
        {
            this.bureau = bureau;
            this.salaire = salaire;
            this.prime = prime;
        }
        public abstract double calculerSalaire();
    }
}
