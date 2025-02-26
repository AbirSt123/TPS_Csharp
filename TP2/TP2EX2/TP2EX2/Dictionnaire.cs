using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2EX2
{
    internal class Dictionnaire : Document
    {
        private string langue;
        private int nbre_def_mots;
        public Dictionnaire(string titre, string langue, int nbr_def_mots) : base(titre) {
            this.langue = langue;
            this.nbre_def_mots = nbr_def_mots;

        }
        public string Langue
        {
            get { return langue; }
            set { langue = value; }
        }
        public int NbrDefMots
        {
            get { return nbre_def_mots; }
            set { nbre_def_mots = value; }
        }
        override
        public String description()
        {
            return $"Titre : {Titre} , numéro d'enregistrement : {NumEnregistrement} , Langue : {langue} , Nombre de définitions de mots : {nbre_def_mots}";
        }
    }
}
