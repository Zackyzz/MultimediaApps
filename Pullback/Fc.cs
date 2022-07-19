using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pullback
{
    class Fc<Td, Tc> : IFunctie<string, string>
    {
        public string Calcul(string intrare)
        {
            return intrare == "x1" ? "z1" : "z2";
        }
    }
}
