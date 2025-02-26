using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2EX2
{
    internal abstract class Document
    {
        private int num_enregistrement;
        private static int compteur = 0;
        private string titre;
        public Document(string titre)
        {
            this.titre = titre;
            this.num_enregistrement = compteur ++;
        }
        public string Titre{
            get { return titre; }
            set { titre = value; }
        }
        public int NumEnregistrement
        {
            get { return num_enregistrement; }
        }
        public abstract string description();
     


    }
}
