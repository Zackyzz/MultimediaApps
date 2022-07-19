using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TonomatMealy
{
    abstract class TonomatMealyAbstract
    {
        public IFunctie ff, gg;
        public TonomatMealyAbstract(IFunctie fi, IFunctie gi)
        {
            ff = fi;
            gg = gi;
        }
        public abstract string f(string stare, string intrare);
        public abstract string g(string stare, string intrare);
        public abstract string evolutie(string stareInitiala, string stringIntrare);
    }
}
