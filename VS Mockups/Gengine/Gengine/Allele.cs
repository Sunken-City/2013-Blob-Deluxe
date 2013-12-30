using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gengine
{
    public class Allele <T>
    {
        public T value;
        public int dominance;

        public Allele(T input)
        {
            value = input;
            dominance = 0;
        }

        public Allele(T input, int dom)
        {
            value = input;
            dominance = dom;
        }
    }
}
