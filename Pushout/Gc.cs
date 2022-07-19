using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pushout
{
    class Gc<Td, Tc> : IFunctie<string, string>
    {
        public string Calcul(string intrare)
        {
            return intrare == "w1" ? "y1" : "y2";
        }
    }
}
