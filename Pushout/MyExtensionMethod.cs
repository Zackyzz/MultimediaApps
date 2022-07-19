using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pushout
{
    static class MyExtensionMethod
    {
        public static HashSet<List<T2>>
            Pushout<T1, T2>(this IEnumerable<T1> codomeniu,
            HashSet<T1> domeniu, IFunctie<T1, T2> fi, IFunctie<T1, T2> gi)
        {
            HashSet<List<T2>> pushOuts = new HashSet<List<T2>>();

            List<T2> cloneDF = new List<T2>();
            List<T2> cloneDG = new List<T2>();
            foreach (T1 a in domeniu)
            {
                cloneDF.Add(fi.Calcul(a));
                cloneDG.Add(gi.Calcul(a));
            }
            cloneDG = cloneDG.Distinct().ToList();
            cloneDF = cloneDF.Distinct().ToList();

            int size = cloneDF.Count() + cloneDG.Count();
            int[,] matrixQ = new int[size, size];
            foreach (T1 a in domeniu)
            {
                int r = cloneDF.IndexOf(fi.Calcul(a));
                int c = cloneDF.Count() + cloneDG.IndexOf(gi.Calcul(a));
                matrixQ[r, c] = 1;
                matrixQ[c, r] = 1;
                matrixQ[r, r] = 1;
                matrixQ[c, c] = 1;
            }

            int[] classQ = new int[size];
            int classP = 1;
            while (Array.FindIndex(classQ, x => x == 0) != -1)
            {
                int firstZero = Array.FindIndex(classQ, x => x == 0);
                classQ[firstZero] = classP;
                for (int j = 0; j < size; j++)
                {
                    if (matrixQ[firstZero, j] == 1 && classQ[j] == 0)
                    {
                        classQ[j] = -1;
                    }
                }

                while (Array.FindIndex(classQ, x => x == -1) != -1)
                {
                    int firstM1 = Array.FindIndex(classQ, x => x == -1);
                    classQ[firstM1] = classP;
                    for (int j = 0; j < size; j++)
                    {
                        if (matrixQ[firstM1, j] == 1 && classQ[j] == 0)
                        {
                            classQ[j] = -1;
                        }
                    }
                }
                classP++;
            }

            List<T2> merged = cloneDF.Union(cloneDG).ToList();
            for (int i = 1; i < classP; i++)
            {
                List<T2> pushedOut = new List<T2>();
                for (int j = 0; j < size; j++)
                {
                    if (classQ[j] == i)
                    {
                        pushedOut.Add(merged[j]);
                    }
                }
                pushOuts.Add(pushedOut);
            }
            return pushOuts;
        }
    }
}
