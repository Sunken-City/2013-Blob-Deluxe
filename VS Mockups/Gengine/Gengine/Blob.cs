using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gengine
{
    class Blob
    {
        Gene<char> gene;

        public Blob(Gene<char> input)
        {
            gene = input;
        }
    }
}
/*Gender :: (Male or Female)

Species :: Species 1 / Species 1 ( Ie, Reptile/dragon means a mostly reptile blob with faint dragon features)

AI :: AI value 1 / AI value 2 (Ie, blob just follows pattern of dominate AI, values can be :: Agreesive, passive, healer, buffer)

Color :: color 1 / color 2*/