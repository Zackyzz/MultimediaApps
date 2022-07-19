using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pullback
{
    class FP : IFunctie<Product, string>
    {
        public string Calcul(Product intrare)
        {
            return intrare.Category;
        }
    }
}
