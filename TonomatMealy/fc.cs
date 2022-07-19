using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TonomatMealy
{
    class Fc : IFunctie
    {
        public string Calcul(string stare, string intrare)
        {
            switch (stare)
            {
                case "1":
                    if (intrare == "a")
                        return "2";
                    break;

                case "2":
                case "3":
                case "4":
                    if (intrare == "a")
                        return "3";
                    else if (intrare == "b")
                        return "4";
                    else if (intrare == "c")
                        return "5";
                    break;

                default:
                    return "";
            }
            return "";
        }
    }
}
