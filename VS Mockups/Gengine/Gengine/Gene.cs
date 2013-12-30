using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gengine
{
    public class Gene <T>
    {
        public Allele<T> alleleA;
        public Allele<T> alleleB;
        private string p1;
        private string p2;

        public Gene(Allele<T> input1, Allele<T> input2)
        {
            alleleA = input1;
            alleleB = input2;
        }

        public Gene (T input1, T input2)
        {
            this.alleleA = new Allele<T> (input1);
            this.alleleB = new Allele<T> (input2);
        }

        public Gene (T input1, int dom1, T input2, int dom2)
        {
            this.alleleA = new Allele<T>(input1, dom1);
            this.alleleB = new Allele<T>(input2, dom2);
        }
    }
}
