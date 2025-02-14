// See https://aka.ms/new-console-template for more information
using System;
using TP1EX2;

class Program
{
    static void Main(string[] args)
    {
        Projet projet = new Projet();
        bool continuer = true;

        while (continuer)
        {
            Console.WriteLine("1. Créer un projet");
            Console.WriteLine("2. Ajouter un programmeur");
            Console.WriteLine("3. Rechercher un programmeur");
            Console.WriteLine("4. Afficher un programmeur");
            Console.WriteLine("5. Afficher la liste des programmeurs");
            Console.WriteLine("6. Supprimer un programmeur");
            Console.WriteLine("7. Ajouter une consommation de café");
            Console.WriteLine("8. Changer le bureau d'un programmeur");
            Console.WriteLine("9. Afficher le nombre total de tasses de café consommé en une semaine donnée");
            Console.WriteLine("10. Quitter");
            Console.Write("Donnez votre choix: ");
            int choix = int.Parse(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    projet.CreerProjet();
                    break;
                case 2:
                    projet.AjouterProgrammeur();
                    break;
                case 3:
                    projet.RechercherProgrammeur();
                    break;
                case 4:
                    projet.AfficherProgrammeur();
                    break;
                case 5:
                    projet.AfficherListeProgrammeurs();
                    break;
                case 6:
                    projet.SupprimerProgrammeur();
                    break;
                case 7:
                    projet.AjouterConsommationCafe();
                    break;
                case 8:
                    projet.ChangerBureauProgrammeur();
                    break;
                case 9:
                    projet.AfficherTotalTassesParSemaine();
                    break;
                case 10:
                    continuer = false;
                    break;
                default:
                    Console.WriteLine("Choix invalide !");
                    break;
            }
        }
    }
}