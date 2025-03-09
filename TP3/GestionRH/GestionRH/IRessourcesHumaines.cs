using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRH
{
    internal interface IRessourcesHumaines
    {
        
        public void Afficher_Enseignants();
        public int Rechercher_Ens(string code);
    }
}
