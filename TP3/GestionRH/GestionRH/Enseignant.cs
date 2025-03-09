using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GestionRH
{
    internal class Enseignant : Personnel
    {
        private Grade grade; 
        private int VH;
        private int nbr_heures_supp;
        private Dictionary<string, List<Etudiant>> grp = new Dictionary<string, List<Etudiant>>();

        public Grade Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public int Vh
        {
            get { return VH; }
            set { VH = value; }
        }

        public int NbrHeuresSupp
        {
            get { return nbr_heures_supp; }
            set { nbr_heures_supp = value; }
        }

        public Dictionary<string, List<Etudiant>> Grp
        {
            get { return grp; }
            set { grp = value; }
        }

        public Enseignant(string code, string nom, string prenom, string bureau, double salaire, double prime, Grade grade, int VH, int nbr_heures_supp)
            : base(code, nom, prenom, bureau, salaire, prime)
        {
            this.VH = VH;
            this.grade = grade;
            this.nbr_heures_supp = nbr_heures_supp;
        }


        override
        public double calculerSalaire()
        {
            if (grade == Grade.PA)
            {
                return (VH + nbr_heures_supp) * 300 + Prime;
            }
            else if (grade == Grade.PH)
            {
                return (VH + nbr_heures_supp) * 350 + Prime;
            }
            else if (grade == Grade.PES)
            {
                return (VH + nbr_heures_supp) * 400 + Prime;
            }
            return 0;
        }

        public void Ajouter_groupe(Groupe groupe)
        {
            grp.Add(groupe.Nom, groupe.Etudiants);
        }
    }
}
