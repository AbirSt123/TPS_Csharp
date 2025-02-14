using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1EX1
{
    public class Fichier
    {
        
        public string Nom { get; set; }
        public string Extension { get; set; }
        public float Taille { get; set; } 

        
        public Fichier(string nom, string extension, float taille)
        {
            Nom = nom;
            Extension = extension;
            Taille = taille;
        }

        
        public void Afficher()
        {
            Console.WriteLine($"Nom: {Nom}, Extension: {Extension}, Taille: {Taille} KO");
        }
    }
}
