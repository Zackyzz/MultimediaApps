using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pushout
{
    abstract class PushoutAbstract<T1, T2>
    {
        public abstract HashSet<List<T2>>
            getPushout(IFunctie<T1, T2> fi, HashSet<T2> codomfi,
            IFunctie<T1, T2> gi, HashSet<T2> codomgi, HashSet<T1> domi);
    }
}
