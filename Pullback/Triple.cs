using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pullback
{
    class Triple<T1, T2, T3>
    {
        public T1 x;
        public T2 z;
        public T3 y;
        public Triple(T1 x, T2 z, T3 y)
        {
            this.x = x;
            this.z = z;
            this.y = y;
        }
    }
}
