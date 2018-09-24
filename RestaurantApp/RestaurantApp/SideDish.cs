using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantte
{
    class SideDish
    {

        private Dictionary<string, int> side_dict = new Dictionary<string, int>()
        {
            {"Chicken curry",500},
            {"Fisdh fillets",100 },
            {"Mushroom poppers",200}

        };
        public int items()
        {
            Menu ob = new Menu();
            return ob.itemselector(side_dict);
        }
    }
}
