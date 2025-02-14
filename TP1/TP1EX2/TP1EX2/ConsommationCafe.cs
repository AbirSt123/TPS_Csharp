using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1EX2
{
    class ConsommationCafe
    {
        public int Semaine { get; set; }
        public int Tasses { get; set; }

        public ConsommationCafe(int semaine, int tasses)
        {
            Semaine = semaine;
            Tasses = tasses;
        }
    }
}
