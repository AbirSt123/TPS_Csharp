using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TP1EX5
{
    class Utilisateur
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public bool SeConnecter()
        {
            Console.Write("Entrez votre login: ");
            string login = Console.ReadLine();
            Console.Write("Entrez votre mot de passe: ");
            string password = Console.ReadLine();

            if (File.Exists("C:/Users/Abir/Documents/C#/TP1EX5/TP1EX5/data.json"))
            {
                string json = File.ReadAllText("C:/Users/Abir/Documents/C#/TP1EX5/TP1EX5/data.json");
                //Console.WriteLine("JSON Content: " + json); // Debug statement

                var utilisateurs = JsonSerializer.Deserialize<Utilisateur[]>(json);

                foreach (var utilisateur in utilisateurs)
                {
                    Console.WriteLine($"Checking: {utilisateur.Login}"); // Debug statement
                    if (utilisateur.Login == login && utilisateur.Password == password)
                    {
                        return true;
                    }
                }
            }
            else
            {
                Console.WriteLine("File not found: data.json"); // Debug statement
            }
            return false;
        }
    }
}
