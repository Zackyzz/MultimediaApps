using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pullback
{
    class GA : IFunctie<Article, string>
    {
        public string Calcul(Article intrare)
        {
            return intrare.Category;
        }
    }
}
