using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2EX2
{
    internal class Livre : Document
    {
        private string auteur;
        private int num_pages;
        public Livre(string titre , string auteur, int num_pages) : base(titre)
        {
            this.auteur = auteur;
            this.num_pages = num_pages;

        }
        public string Auteur
        {
            get { return auteur; }
            set { auteur = value; }
        }
        public int NumPages
        {
            get { return num_pages; }
            set { num_pages = value; }
        }
        
        override
        public string description()
        {
            return $"Titre : {Titre} , numéro d'enregistrement : {NumEnregistrement} , Auteur : {auteur} , numéro des pages : {num_pages}";

        }

    }
}
