using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1EX5
{
    class CompteBancaire
    {
        public int NumeroCompte { get; set; }
        public string NomClient { get; set; }
        public string PrenomClient { get; set; }
        public double Solde { get; set; }
        public List<Operation> Operations { get; set; }

        public CompteBancaire(int numeroCompte, string nomClient, string prenomClient)
        {
            NumeroCompte = numeroCompte;
            NomClient = nomClient;
            PrenomClient = prenomClient;
            Solde = 0.0;
            Operations = new List<Operation>();
        }

        public void Crediter(double montant)
        {
            Solde += montant;
            Operations.Add(new Operation("Crédit", montant));
        }

        public void Debiter(double montant)
        {
            if (montant <= Solde)
            {
                Solde -= montant;
                Operations.Add(new Operation("Débit", montant));
            }
            else
            {
                Console.WriteLine("Solde insuffisant.");
            }
        }

        public void Transferer(CompteBancaire destinataire, double montant)
        {
            if (montant <= Solde)
            {
                Solde -= montant;
                destinataire.Crediter(montant);
                Operations.Add(new Operation("Transfert", montant));
            }
            else
            {
                Console.WriteLine("Solde insuffisant.");
            }
        }

        public void AfficherHistorique()
        {
            foreach (var operation in Operations)
            {
                Console.WriteLine(operation);
            }
        }

        public override string ToString()
        {
            return $"{NumeroCompte} - {NomClient} {PrenomClient} - {Solde} dhs / {Operations.Count} opération(s) effectuée(s)";
        }
    }
}
