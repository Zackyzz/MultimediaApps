using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pushout
{
    class Fc<Td, Tc> : IFunctie<string, string>
    {
        public string Calcul(string intrare)
        {
            return intrare == "w1" ? "x1" : intrare == "w2" ? "x2" : "x3";
        }
    }
}
