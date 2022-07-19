using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pushout
{
    class Program
    {
        static void Main(string[] args)
        {
            Pushout<string, string> pushOut = new Pushout<string, string>();
            Fc<string, string> fi = new Fc<string, string>();
            Gc<string, string> gi = new Gc<string, string>();
            HashSet<string> F = new HashSet<string> { "x1", "x2", "x3" };
            HashSet<string> G = new HashSet<string> { "y1", "y2" };
            HashSet<string> dFG = new HashSet<string> { "w1", "w2", "w3", "w4" };

            Console.WriteLine("Folosind metoda abstracta:");
            HashSet<List<string>> pushoutFG = pushOut.getPushout(fi, F, gi, G, dFG);
            foreach (List<string> a in pushoutFG)
            {
                foreach (string b in a)
                {
                    Console.Write(b + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Folosind metoda extinsa:");
            HashSet<List<string>> pushoutFGExtins = F.Pushout(dFG, fi, gi);
            foreach (List<string> a in pushoutFGExtins)
            {
                foreach (string b in a)
                {
                    Console.Write(b + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
