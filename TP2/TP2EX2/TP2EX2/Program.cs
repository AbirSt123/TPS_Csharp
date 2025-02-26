// See https://aka.ms/new-console-template for more information
using TP2EX2;

class Program
{
    static void Main()
    {
        Biblio bibliotheque = new Biblio();
        bibliotheque.Ajouter_Doc(new Dictionnaire("C#", "Anglais", 2500));
        bibliotheque.Ajouter_Doc(new Dictionnaire("Java", "Francais", 1000));
        bibliotheque.Ajouter_Doc(new Livre("Javascript", "Ahmed Alaoui", 20000));

        Console.WriteLine("Nombre de livres: " + bibliotheque.calculer_nbr_livres());
        Console.WriteLine("Dictionnaires de bibliothèque: ");
        bibliotheque.Afficher_Dictionnaires();

        Console.WriteLine("Tous les auteurs: ");
        bibliotheque.tousLesAuteurs();

        Console.WriteLine("Description de tous les documents");
        bibliotheque.toutesLesDescriptions();
        Console.ReadLine();



    }
}
