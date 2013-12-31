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
        public string name;

        public Gene(string n, Allele<T> input1, Allele<T> input2)
        {
            name = n;
            alleleA = input1;
            alleleB = input2;
        }

        public Gene (string n, T input1, T input2)
        {
            name = n;
            this.alleleA = new Allele<T> (input1);
            this.alleleB = new Allele<T> (input2);
        }

        public Gene(string n, T input1, int dom1, T input2, int dom2)
        {
            name = n;
            this.alleleA = new Allele<T>(input1, dom1);
            this.alleleB = new Allele<T>(input2, dom2);
        }
    }
}
