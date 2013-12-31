using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gengine
{
    public class Blob
    {
        public enum Gender { Male, Female }
        public int gender;
        public int numGenes = 0;

        private Dictionary<string, object> DNA = new Dictionary<string, object>();


        public Blob(Gene<char> input)
        {
            addGene<char>(input);
        }

        public Blob()
        {
            gender = 1;
        }

        public void addGene<T>(Gene<T> gene)
        {
            DNA.Add(gene.name, gene);
            numGenes++;
        }

        public Gene<T> getGene<T>(string name)
        {
            return DNA[name] as Gene<T>;
        }
    }

}
/*Gender :: (Male or Female)

Species :: Species 1 / Species 1 ( Ie, Reptile/dragon means a mostly reptile blob with faint dragon features)

AI :: AI value 1 / AI value 2 (Ie, blob just follows pattern of dominate AI, values can be :: Agreesive, passive, healer, buffer)

Color :: color 1 / color 2*/