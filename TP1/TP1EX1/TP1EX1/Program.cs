// See https://aka.ms/new-console-template for more information
using System;

namespace TP1EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Repertoire monRepertoire = new Repertoire("Documents");

            
            monRepertoire.Ajouter(new Fichier("rapport", "pdf", 120));
            monRepertoire.Ajouter(new Fichier("presentation", "ppt", 450));
            monRepertoire.Ajouter(new Fichier("photo", "jpg", 800));

            
            monRepertoire.Afficher();

            
            int index = monRepertoire.Rechercher("rapport");
            if (index != -1)
            {
                Console.WriteLine("Fichier trouvé à l'indice: " + index);
            }
            else
            {
                Console.WriteLine("Fichier non trouvé.");
            }

            
            monRepertoire.RechercherParExtension("pdf");

            
            monRepertoire.Supprimer("photo");

            
            monRepertoire.Renommer("rapport", "rapport_final");

            
            monRepertoire.ModifierTaille("presentation", 500);

            
            float tailleTotaleMO = monRepertoire.GetTaille();
            Console.WriteLine($"Taille totale du répertoire: {tailleTotaleMO} MO");
        }
    }
}
