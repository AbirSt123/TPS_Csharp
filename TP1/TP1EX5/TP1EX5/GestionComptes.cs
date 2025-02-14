using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1EX5
{
    class GestionComptes
    {
        private List<CompteBancaire> comptes;

        public GestionComptes()
        {
            comptes = new List<CompteBancaire>();
            ChargerComptes();
        }

        public void AjouterCompte()
        {
            Console.Write("Entrez le numéro du compte bancaire: ");
            int numeroCompte = int.Parse(Console.ReadLine());
            Console.Write("Entrez le nom du client: ");
            string nomClient = Console.ReadLine();
            Console.Write("Entrez le prénom du client: ");
            string prenomClient = Console.ReadLine();

            CompteBancaire compte = new CompteBancaire(numeroCompte, nomClient, prenomClient);
            comptes.Add(compte);
            SauvegarderComptes();
            Console.WriteLine("Création de compte effectuée......");
        }

        public void RechercherCompte()
        {
            Console.Write("Entrez le numéro du compte: ");
            int numeroCompte = int.Parse(Console.ReadLine());

            CompteBancaire compte = comptes.Find(c => c.NumeroCompte == numeroCompte);
            if (compte != null)
            {
                Console.WriteLine(compte);
            }
            else
            {
                Console.WriteLine($"Le compte {numeroCompte} n'existe pas !!!");
            }
        }

        public void SupprimerCompte()
        {
            Console.Write("Entrez le numéro du compte: ");
            int numeroCompte = int.Parse(Console.ReadLine());

            CompteBancaire compte = comptes.Find(c => c.NumeroCompte == numeroCompte);
            if (compte != null)
            {
                comptes.Remove(compte);
                SauvegarderComptes();
                Console.WriteLine("Compte supprimé ......");
            }
            else
            {
                Console.WriteLine($"Le compte {numeroCompte} n'existe pas !!!");
            }
        }

        public void OperationSurCompte()
        {
            Console.Write("Entrez le numéro du compte: ");
            int numeroCompte = int.Parse(Console.ReadLine());

            CompteBancaire compte = comptes.Find(c => c.NumeroCompte == numeroCompte);
            if (compte != null)
            {
                bool revenir = false;
                while (!revenir)
                {
                    Console.WriteLine("=============================================================================");
                    Console.WriteLine($"OPERATION SUR LE COMPTE {numeroCompte}");
                    Console.WriteLine("1) Créditer");
                    Console.WriteLine("2) Débiter");
                    Console.WriteLine("3) Historique");
                    Console.WriteLine("4) Transfert d'argent");
                    Console.WriteLine("5) Revenir au menu principal");
                    Console.WriteLine("=============================================================================");
                    Console.Write("Donnez votre choix: ");
                    int choix = int.Parse(Console.ReadLine());

                    switch (choix)
                    {
                        case 1:
                            Console.Write("Entrez le montant à verser: ");
                            double montantCredit = double.Parse(Console.ReadLine());
                            compte.Crediter(montantCredit);
                            SauvegarderComptes();
                            break;
                        case 2:
                            Console.Write("Entrez le montant à retirer: ");
                            double montantDebit = double.Parse(Console.ReadLine());
                            compte.Debiter(montantDebit);
                            SauvegarderComptes();
                            break;
                        case 3:
                            compte.AfficherHistorique();
                            break;
                        case 4:
                            Console.Write("Entrez le numéro du destinataire: ");
                            int numeroDestinataire = int.Parse(Console.ReadLine());
                            CompteBancaire destinataire = comptes.Find(c => c.NumeroCompte == numeroDestinataire);
                            if (destinataire != null)
                            {
                                Console.Write("Entrez le montant à transférer: ");
                                double montantTransfert = double.Parse(Console.ReadLine());
                                compte.Transferer(destinataire, montantTransfert);
                                SauvegarderComptes();
                            }
                            else
                            {
                                Console.WriteLine($"Le compte {numeroDestinataire} n'existe pas !!!");
                            }
                            break;
                        case 5:
                            revenir = true;
                            break;
                        default:
                            Console.WriteLine("Choix invalide. Veuillez réessayer.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine($"Le compte {numeroCompte} n'existe pas !!!");
            }
        }

        public void AfficherTousLesComptes()
        {
            foreach (var compte in comptes)
            {
                Console.WriteLine(compte);
            }
        }

        private void ChargerComptes()
        {
            if (File.Exists("comptes.txt"))
            {
                string[] lignes = File.ReadAllLines("comptes.txt");
                foreach (var ligne in lignes)
                {
                    string[] elements = ligne.Split(';');
                    CompteBancaire compte = new CompteBancaire(int.Parse(elements[0]), elements[1], elements[2]);
                    compte.Solde = double.Parse(elements[3]);
                    comptes.Add(compte);
                }
            }
        }

        private void SauvegarderComptes()
        {
            List<string> lignes = new List<string>();
            foreach (var compte in comptes)
            {
                lignes.Add($"{compte.NumeroCompte};{compte.NomClient};{compte.PrenomClient};{compte.Solde}");
            }
            File.WriteAllLines("comptes.txt", lignes);
        }
    }
}
