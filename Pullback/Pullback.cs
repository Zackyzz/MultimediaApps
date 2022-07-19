using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pullback
{
    class Pullback<T1,T2,T3> : PullbackAbstract<T1, T2, T3>
    {
        public override HashSet<Triple<T1, T2, T3>>
            getPullback(IFunctie<T1, T2> fi, HashSet<T1> domfi,
            IFunctie<T3, T2> gi, HashSet<T3> domgi,
            HashSet<T2> codomi, Func<T2, T2, bool> comp)
        {
            HashSet<Triple<T1, T2, T3>> pullBacks = new HashSet<Triple<T1, T2, T3>>();
            foreach (T1 a in domfi)
            {
                foreach (T3 b in domgi)
                {
                    if (comp(fi.Calcul(a), gi.Calcul(b)))
                        pullBacks.Add(new Triple<T1, T2, T3>(a, fi.Calcul(a), b));
                }
            }
            return pullBacks;
        }
    }
}
