using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1EX1
{
    public class Repertoire
    {
        
        public string Nom { get; set; }
        public int NbrFichiers { get; private set; }
        private Fichier[] fichiers;

        public Repertoire(string nom)
        {
            Nom = nom;
            fichiers = new Fichier[30];
            NbrFichiers = 0;
        }

        
        public void Afficher()
        {
            Console.WriteLine($"Répertoire: {Nom}");
            for (int i = 0; i < NbrFichiers; i++)
            {
                fichiers[i].Afficher();
            }
        }

        
        public int Rechercher(string nom)
        {
            for (int i = 0; i < NbrFichiers; i++)
            {
                if (fichiers[i].Nom == nom)
                {
                    return i;
                }
            }
            return -1;
        }

        
        public void Ajouter(Fichier fichier)
        {
            if (NbrFichiers < 30)
            {
                fichiers[NbrFichiers] = fichier;
                NbrFichiers++;
            }
            else
            {
                Console.WriteLine("Le répertoire est plein, impossible d'ajouter un nouveau fichier.");
            }
        }

        
        public void RechercherParExtension(string extension)
        {
            Console.WriteLine($"Fichiers avec l'extension {extension}:");
            for (int i = 0; i < NbrFichiers; i++)
            {
                if (fichiers[i].Extension == extension)
                {
                    fichiers[i].Afficher();
                }
            }
        }

        
        public void Supprimer(string nom)
        {
            int index = Rechercher(nom);
            if (index != -1)
            {
                for (int i = index; i < NbrFichiers - 1; i++)
                {
                    fichiers[i] = fichiers[i + 1];
                }
                NbrFichiers--;
                Console.WriteLine($"Fichier {nom} supprimé.");
            }
            else
            {
                Console.WriteLine($"Fichier {nom} non trouvé.");
            }
        }

        
        public void Renommer(string ancienNom, string nouveauNom)
        {
            int index = Rechercher(ancienNom);
            if (index != -1)
            {
                fichiers[index].Nom = nouveauNom;
                Console.WriteLine($"Fichier {ancienNom} renommé en {nouveauNom}.");
            }
            else
            {
                Console.WriteLine($"Fichier {ancienNom} non trouvé.");
            }
        }

        
        public void ModifierTaille(string nom, float nouvelleTaille)
        {
            int index = Rechercher(nom);
            if (index != -1)
            {
                fichiers[index].Taille = nouvelleTaille;
                Console.WriteLine($"Taille du fichier {nom} modifiée à {nouvelleTaille} KO.");
            }
            else
            {
                Console.WriteLine($"Fichier {nom} non trouvé.");
            }
        }

        
        public float GetTaille()
        {
            float tailleTotaleKO = 0;
            for (int i = 0; i < NbrFichiers; i++)
            {
                tailleTotaleKO += fichiers[i].Taille;
            }
            return tailleTotaleKO / 1024;
        }
    }
}
