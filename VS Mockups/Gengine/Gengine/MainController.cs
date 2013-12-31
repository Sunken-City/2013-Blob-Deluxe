using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gengine
{
    class MainController
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crossing Aa and Aa");
            Gene<char> AA = new Gene<char>("Example", 'A', 1, 'A', 1);
            Gene<char> Aa = new Gene<char>("Example", 'A', 1, 'a', 0);
            Gene<char> aa = new Gene<char>("Example", 'a', 0, 'a', 0);

            Blob Mom = new Blob(Aa);
            Blob Dad = new Blob(Aa);

            for (int i = 0; i < 20; i++)
			{
			  Blob child = Punnett.cross(Mom, Dad);
              Console.WriteLine(child.getGene<char>("Example").alleleA.value.ToString() + child.getGene<char>("Example").alleleB.value.ToString());
			}

            Console.ReadLine();
        }
    }
}
