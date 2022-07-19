using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pullback
{
    abstract class PullbackAbstract<T1, T2, T3>
    {
        public abstract HashSet<Triple<T1, T2, T3>>
            getPullback(IFunctie<T1, T2> fi, HashSet<T1> domfi,
            IFunctie<T3, T2> gi, HashSet<T3> domgi,
            HashSet<T2> codomi, Func<T2, T2, bool> comp);
    }
}
