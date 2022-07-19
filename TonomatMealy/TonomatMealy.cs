using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TonomatMealy
{
    class TonomatMealy : TonomatMealyAbstract
    {
        public TonomatMealy(IFunctie fi, IFunctie gi) : base(fi, gi)
        {
            ff = fi;
            gg = gi;
        }
        public override string f(string stare, string intrare)
        {
            return ff.Calcul(stare, intrare);
        }
        public override string g(string stare, string intrare)
        {
            return gg.Calcul(stare, intrare);
        }
        public override string evolutie(string stareInitiala, string stringIntrare)
        {
            string stareNoua = stareInitiala;

            for (int i = 0; i < stringIntrare.Length; i++)
            {
                stareNoua = f(stareNoua, stringIntrare.Substring(i, 1));
                stareInitiala += " : " + g("", stringIntrare.Substring(i, 1)) + " -> " + stareNoua;
            }
            return stareInitiala;
        }
    }
}
