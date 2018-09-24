using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantte
{
    class Desserts
    {
        private Dictionary<string, int> dess_dict = new Dictionary<string, int>()
        {
            {"Smoothie",100 },
            {"Strawberry Smoothie",50},
            {"Chocolate cake",250 }

        };

        public int items()
        {
          
                Menu ob = new Menu();
                return ob.itemselector(dess_dict);
            
        }
    }
}
