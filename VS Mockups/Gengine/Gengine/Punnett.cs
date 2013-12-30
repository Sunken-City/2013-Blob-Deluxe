using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gengine
{
    public static class Punnett
    {
        public static Random random = new Random();
        public static Gene<T> cross<T>(Gene<T> g1, Gene<T> g2)
        {
            
            int randomNumber = random.Next(1, 5);
            Gene<T> offspring;

            if (randomNumber == 1)
                if (g1.alleleA.dominance >= g2.alleleA.dominance)
                    offspring = new Gene<T>(g1.alleleA, g2.alleleA);
                else
                    offspring = new Gene<T>(g2.alleleA, g1.alleleA);

            else if (randomNumber == 2)
                if (g1.alleleA.dominance >= g2.alleleB.dominance)
                    offspring = new Gene<T>(g1.alleleA, g2.alleleB);
                else
                    offspring = new Gene<T>(g2.alleleA, g1.alleleB);

            else if (randomNumber == 3)
                if (g1.alleleB.dominance >= g2.alleleA.dominance)
                    offspring = new Gene<T>(g1.alleleB, g2.alleleA);
                else
                    offspring = new Gene<T>(g2.alleleB, g1.alleleA);

            else
                if (g1.alleleB.dominance >= g2.alleleB.dominance)
                    offspring = new Gene<T>(g1.alleleB, g2.alleleB);
                else
                    offspring = new Gene<T>(g2.alleleB, g1.alleleB);

            return offspring;
        }
    }
}
