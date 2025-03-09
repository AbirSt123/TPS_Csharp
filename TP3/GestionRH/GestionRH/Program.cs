using System;

namespace GestionRH
{
    class Program
    {
        static void Main(string[] args)
        {
            RessourcesHumaines rh = new RessourcesHumaines();

            Enseignant ens1 = new Enseignant("AAAAA", "Alaoui", "Imane", "Bureau 10", 0, 0, Grade.PA, 20, 5);
            Enseignant ens2 = new Enseignant("BBBBB", "Alaoui", "Ahmed", "Bureau 20", 0, 0, Grade.PH, 30, 8);

            Etudiant etudiant1 = new Etudiant("AP2", 15.5f, "AB009", "Iman", "benjelloun");
            Etudiant etudiant2 = new Etudiant("AP2", 16.0f, "A5647", "Saida", "Idrissi");
            Etudiant etudiant3 = new Etudiant("AP1", 14.9f, "AB008", "Ahmed", "benjelloun");
            Etudiant etudiant4 = new Etudiant("AP1", 17.0f, "A5678", "Kawtar", "Idrissi");

            Groupe TD1 = new Groupe("Groupe TD1");
            TD1.Ajouter_etudiant(etudiant1);
            TD1.Ajouter_etudiant(etudiant2);

            Groupe TD2 = new Groupe("Groupe TD2");
            TD2.Ajouter_etudiant(etudiant1);
            TD2.Ajouter_etudiant(etudiant2);

            ens1.Ajouter_groupe(TD1);
            ens2.Ajouter_groupe(TD1);
            ens2.Ajouter_groupe(TD2);
            
            rh.AjouterPersonnel(ens1);
            rh.AjouterPersonnel(ens2);

            Directeur dir = Directeur.getDirecteur("D0012", "Idrissi", "Said", "Bureau 102", 10000, 2000);
            dir.calculerSalaire();
            rh.AjouterPersonnel(dir);

            rh.Afficher_Enseignants();
        }
    }
}
