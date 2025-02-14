using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1EX5
{
    class Operation
    {
        public string Type { get; set; }
        public double Montant { get; set; }
        public DateTime Date { get; set; }

        public Operation(string type, double montant)
        {
            Type = type;
            Montant = montant;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Date} - {Type} de {Montant} dhs";
        }
    }
}
