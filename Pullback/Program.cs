using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pullback
{
    class Program
    {
        static void Main(string[] args)
        {
            Pullback<string, string, string> pullBack = new Pullback<string, string, string>();

            Fc<string, string> fi = new Fc<string, string>();
            Gc gi = new Gc();
            HashSet<string> F = new HashSet<string> { "x1", "x2", "x3" };
            HashSet<string> G = new HashSet<string> { "y1", "y2", "y3", "y4" };
            HashSet<string> imFG = new HashSet<string> { "z1", "z2", "z3", "z4" };

            HashSet<Triple<string, string, string>> pullBackFG =
                pullBack.getPullback(fi, F, gi, G, imFG, (a, b) => a == b);

            foreach (Triple<string, string, string> element in pullBackFG)
            {
                Console.WriteLine("(" + element.x + ", " + element.y + ", " + element.z + ")");
            }

            Pullback<Product, string, Article> pullBackAP = new Pullback<Product, string, Article>();

            FP FPf = new FP();
            Product p1 = new Product(1, "", "", 1, "xx");
            Product p2 = new Product(2, "", "", 2, "yy");
            Product p3 = new Product(3, "", "", 3, "qq");
            Product p4 = new Product(4, "", "", 4, "ww");
            HashSet<Product> FPmi = new HashSet<Product> { p1, p2, p3, p4 };

            GA GAf = new GA();
            Article a1 = new Article(6, "", "", 1, "xx");
            Article a2 = new Article(8, "", "", 2, "yy");
            Article a3 = new Article(10, "", "", 3, "zz");
            Article a4 = new Article(12, "", "", 4, "ww");
            HashSet<Article> GAmi = new HashSet<Article> { a1, a2, a3, a4 };

            HashSet<string> imFG2 = new HashSet<string> { "xx", "yy", "ww", "aa" };

            HashSet<Triple<Product, string, Article>> pullBacksAP =
                pullBackAP.getPullback(FPf, FPmi, GAf, GAmi, imFG2, (a, b) => a == b);

            foreach (Triple<Product, string, Article> element in pullBacksAP)
            {
                Console.WriteLine("(" + element.x.ProductID.ToString() + ", " +
                    element.z + ", " + element.y.ArticleId.ToString() + ")");
            }
            Console.ReadLine();
        }
    }
}
