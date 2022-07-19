using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pullback
{
    class Gc : IFunctie<string, string>
    {
        public string Calcul(string intrare)
        {
            return intrare == "y1" ? "z1" : intrare == "y3" ? "z4" : "z2";
        }
    }
}
