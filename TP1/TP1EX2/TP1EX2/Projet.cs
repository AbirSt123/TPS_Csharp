using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1EX2
{
    class Projet
    {
        public string Code { get; set; }
        public string Sujet { get; set; }
        public int Duree { get; set; }
        public List<Programmeur> Programmeurs { get; set; }

        public Projet()
        {
            Programmeurs = new List<Programmeur>();
        }

        public void CreerProjet()
        {
            Console.Write("Entrez le code du projet: ");
            Code = Console.ReadLine();
            Console.Write("Entrez le sujet du projet: ");
            Sujet = Console.ReadLine();
            Console.Write("Entrez la durée du projet en semaines: ");
            Duree = int.Parse(Console.ReadLine());
            Console.WriteLine("Projet créé avec succès !");
        }

        public void AjouterProgrammeur()
        {
            Console.Write("Entrez le nom du programmeur: ");
            string nom = Console.ReadLine();
            Console.Write("Entrez le bureau du programmeur: ");
            string bureau = Console.ReadLine();
            Programmeurs.Add(new Programmeur(nom, bureau));
            Console.WriteLine("Programmeur ajouté avec succès !");
        }

        public void RechercherProgrammeur()
        {
            Console.Write("Entrez le nom du programmeur à rechercher: ");
            string nom = Console.ReadLine();
            Programmeur programmeur = Programmeurs.Find(p => p.Nom == nom);
            if (programmeur != null)
            {
                Console.WriteLine("Programmeur trouvé : " + programmeur.Nom);
            }
            else
            {
                Console.WriteLine("Programmeur non trouvé !");
            }
        }

        public void AfficherProgrammeur()
        {
            Console.Write("Entrez le nom du programmeur à afficher: ");
            string nom = Console.ReadLine();
            Programmeur programmeur = Programmeurs.Find(p => p.Nom == nom);
            if (programmeur != null)
            {
                programmeur.Afficher();
            }
            else
            {
                Console.WriteLine("Programmeur non trouvé !");
            }
        }

        public void AfficherListeProgrammeurs()
        {
            foreach (var programmeur in Programmeurs)
            {
                programmeur.Afficher();
            }
        }

        public void SupprimerProgrammeur()
        {
            Console.Write("Entrez le nom du programmeur à supprimer: ");
            string nom = Console.ReadLine();
            Programmeur programmeur = Programmeurs.Find(p => p.Nom == nom);
            if (programmeur != null)
            {
                Programmeurs.Remove(programmeur);
                Console.WriteLine("Programmeur supprimé avec succès !");
            }
            else
            {
                Console.WriteLine("Programmeur non trouvé !");
            }
        }

        public void AjouterConsommationCafe()
        {
            Console.Write("Entrez le nom du programmeur: ");
            string nom = Console.ReadLine();
            Programmeur programmeur = Programmeurs.Find(p => p.Nom == nom);
            if (programmeur != null)
            {
                Console.Write("Entrez la semaine: ");
                int semaine = int.Parse(Console.ReadLine());
                Console.Write("Entrez le nombre de tasses: ");
                int tasses = int.Parse(Console.ReadLine());
                programmeur.AjouterConsommation(semaine, tasses);
                Console.WriteLine("Consommation ajoutée avec succès !");
            }
            else
            {
                Console.WriteLine("Programmeur non trouvé !");
            }
        }

        public void ChangerBureauProgrammeur()
        {
            Console.Write("Entrez le nom du programmeur: ");
            string nom = Console.ReadLine();
            Programmeur programmeur = Programmeurs.Find(p => p.Nom == nom);
            if (programmeur != null)
            {
                Console.Write("Entrez le nouveau bureau: ");
                string bureau = Console.ReadLine();
                programmeur.Bureau = bureau;
                Console.WriteLine("Bureau changé avec succès !");
            }
            else
            {
                Console.WriteLine("Programmeur non trouvé !");
            }
        }

        public void AfficherTotalTassesParSemaine()
        {
            Console.Write("Entrez la semaine: ");
            int semaine = int.Parse(Console.ReadLine());
            int total = 0;
            foreach (var programmeur in Programmeurs)
            {
                total += programmeur.GetConsommationSemaine(semaine);
            }
            Console.WriteLine("Total de tasses consommées en semaine " + semaine + " : " + total);
        }
    }
}
