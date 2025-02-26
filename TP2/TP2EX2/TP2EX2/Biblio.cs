using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2EX2
{
    internal class Biblio
    {
        public List<Document> Documents = new List<Document>();
        public void Ajouter_Doc(Document doc)
        {
            Documents.Add(doc);

        }
        public int calculer_nbr_livres()
        {
            int nbr_livres = 0;

            foreach (var doc in Documents)
            {
                if (doc is Livre)
                    nbr_livres++;
            }
            return nbr_livres;
        }
        public void Afficher_Dictionnaires()
        {
            
                foreach(var doc in Documents){
                    if(doc is Dictionnaire) {
                    Console.WriteLine(doc.description());
                    }

                }
        }
        public void tousLesAuteurs()
        {
            foreach(var doc in Documents)
            { 
                Console.WriteLine("Numéro " + doc.NumEnregistrement );
                if(doc is Livre livre)
                {
                    Console.WriteLine("Auteur: " + livre.Auteur);
                }
                else
                {
                    Console.WriteLine("Pas d'auteur");
                }
            }

        }
        public void toutesLesDescriptions()
        {
            foreach(var doc in Documents)
            {
                Console.WriteLine(doc.description());
            }
        }
    }
}
