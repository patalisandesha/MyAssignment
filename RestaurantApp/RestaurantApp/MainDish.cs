using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantte
{
    public class MainDish : Products
    {
        private Dictionary<string, int> main_dict = new Dictionary<string, int>()
        {
            {" Veg Pallav ",100},
            {"Rice Bath",50 },
            {" Dosa ",75 }

        };

        public int items()
        {
            Menu obj = new Menu();
            return obj.itemselector(main_dict);
        }        
    }
}
