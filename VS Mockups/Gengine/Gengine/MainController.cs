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
            Gene<char> AA = new Gene<char>('A', 1, 'A', 1); 
            Gene<char> Aa = new Gene<char>('A', 1, 'a', 0);
            Gene<char> aa = new Gene<char>('a', 0, 'a', 0);

            Gene<char> offspring;
            for (int i = 0; i < 20; i++)
			{
			  offspring = Punnett.cross<char>(Aa, Aa);
              Console.WriteLine(offspring.alleleA.value.ToString() + offspring.alleleB.value.ToString());
			}

            Console.ReadLine();
        }
    }
}
