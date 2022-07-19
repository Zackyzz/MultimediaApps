using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pushout
{
    interface IFunctie<Td, Tc>
    {
        Tc Calcul(Td intrare);
    }
}
