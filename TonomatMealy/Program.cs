using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TonomatMealy
{
    class Program
    {
        static void Main(string[] args)
        {
            IFunctie f = new Fc();
            IFunctie g = new Gc();
            TonomatMealy myAutomat = new TonomatMealy(f, g);

            Console.WriteLine(myAutomat.evolutie("1", "aabbac"));
            Console.ReadLine();
        }
    }
}
