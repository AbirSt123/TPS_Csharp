// See https://aka.ms/new-console-template for more information
using TP2EX1;

class Program
{
    static void Main()
    {
        GestionEmployes gestionEmployes = new GestionEmployes();
        gestionEmployes.AjouterEmploye(new Employee("Imane", 5000, "Développeur", new DateTime(2019, 6, 1)));
        gestionEmployes.AjouterEmploye(new Employee("Ahmed", 6000, "Ingénieur DevOps", new DateTime(2018,7,1)));
        gestionEmployes.AjouterEmploye(new Employee("Saide", 8000, "Chef de Projet", new DateTime(2021, 8, 1)));
        Directeur directeur = Directeur.GetInstance();

        
        directeur.SetGestionEmployes(gestionEmployes);


       
        double salaireTotal = directeur.GetSalaireTotal();
        double salaireMoyen = directeur.GetSalaireMoyen();

        Console.WriteLine($"Salaire total de l'entreprise: {salaireTotal}");
        Console.WriteLine($"Salaire moyen des employés: {salaireMoyen}");

       
        Console.WriteLine($"Salaire total de l'entreprise: {salaireTotal:C}");
        Console.WriteLine($"Salaire moyen des employés: {salaireMoyen:C}");

       
        Console.WriteLine("\nListe des employés:");
        foreach (var emp in directeur.GetEmployes())
        {
            Console.WriteLine($"Nom: {emp.Nom}, Salaire: {emp.Salaire:C}, Poste: {emp.Post}, Date d'embauche: {emp.Date_Embauche:yyyy-MM-dd}");
        }
        Console.ReadLine();
    }

}

    
