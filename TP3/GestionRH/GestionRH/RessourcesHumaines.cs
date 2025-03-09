using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRH
{
    internal class RessourcesHumaines : IRessourcesHumaines
    {
        private List<Personnel> personnelList = new List<Personnel>();
        public void Afficher_Enseignants()
        {
            foreach (var personnel in personnelList)
            {
                if (personnel is Enseignant enseignant)
                {
                    Console.WriteLine($"Enseignant: {enseignant.Nom} {enseignant.Prenom}");
                    Console.WriteLine($"Salaire: {enseignant.calculerSalaire()} DH");
                    foreach (var groupe in enseignant.Grp)
                    {
                        Groupe tempGroupe = new Groupe(groupe.Key)
                        {
                            Etudiants = groupe.Value
                        };
                        tempGroupe.Afficher_grp();
                    }
                }
            }

        }
        public int Rechercher_Ens(string code)
        {
            for (int i = 0; i < personnelList.Count; i++)
            {
                if (personnelList[i] is Enseignant enseignant && enseignant.Code == code)
                {
                    return i;
                }
            }
            return -1;
        }

        public void AjouterPersonnel(Personnel personnel)
        {
            personnelList.Add(personnel);
        }
    }
}
