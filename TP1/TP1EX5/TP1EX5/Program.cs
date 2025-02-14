// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using TP1EX5;

namespace GestionComptesBancaires
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionComptes gestionComptes = new GestionComptes();
            Utilisateur utilisateur = new Utilisateur();

            Console.WriteLine("Bienvenue dans le système de gestion des comptes bancaires.");
            Console.WriteLine("Veuillez vous connecter.");

            if (utilisateur.SeConnecter())
            {
                bool quitter = false;
                while (!quitter)
                {
                    Console.WriteLine("=============================================================================");
                    Console.WriteLine("1) Ajouter un nouveau compte");
                    Console.WriteLine("2) Rechercher un compte");
                    Console.WriteLine("3) Supprimer un compte");
                    Console.WriteLine("4) Opération sur un compte");
                    Console.WriteLine("5) Afficher tous les comptes");
                    Console.WriteLine("6) Quitter le programme");
                    Console.WriteLine("=============================================================================");
                    Console.Write("Donnez votre choix: ");
                    int choix = int.Parse(Console.ReadLine());

                    switch (choix)
                    {
                        case 1:
                            gestionComptes.AjouterCompte();
                            break;
                        case 2:
                            gestionComptes.RechercherCompte();
                            break;
                        case 3:
                            gestionComptes.SupprimerCompte();
                            break;
                        case 4:
                            gestionComptes.OperationSurCompte();
                            break;
                        case 5:
                            gestionComptes.AfficherTousLesComptes();
                            break;
                        case 6:
                            quitter = true;
                            break;
                        default:
                            Console.WriteLine("Choix invalide. Veuillez réessayer.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Échec de la connexion. Veuillez vérifier vos identifiants.");
            }
        }
    }
}
