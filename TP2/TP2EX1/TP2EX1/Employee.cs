using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2EX1
{
    internal class Employee
    {
        private string nom;
        private double salaire;
        private string post;
        private DateTime date_embauche;

        public Employee(string nom,double salaire, string post, DateTime date_embauche)
        {
            this.nom = nom;
            this.salaire = salaire;
            this.post = post;
            this.date_embauche = date_embauche;
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public double Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }
        public String Post
        {
            get { return post; }
            set { post = value; }
        }
        public DateTime Date_Embauche
        {
            get { return date_embauche; }
            set { date_embauche = value; }
        }

    }
}
