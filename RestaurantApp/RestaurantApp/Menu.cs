using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantte
{
    class Menu
    {
       public int itemselector(Dictionary<string, int> myDictionary)
        {
            Orders obj = new Orders();

            while (true)
            {
                Console.WriteLine("\nSelect the item:\n");
                int count = 1; int opt;
                foreach (KeyValuePair<string, int> i in myDictionary)
                {
                    Console.WriteLine(count++ + "." + i.Key.ToString() + "  -  " + i.Value.ToString());

                }
                Console.WriteLine(count++ + ".Proceed to Main Menu");
                Console.WriteLine(count + ".Proceed to Bill");


                opt = Convert.ToInt32(Console.ReadLine());
                if (opt == count)
                {

                    obj.bill();
                    return 1;

                }
                else if (opt == count - 1)
                {
                    return 0;
                }
                else
                {
                    int value =myDictionary.Values.ElementAt(opt - 1);
                    string key = myDictionary.Keys.ElementAt(opt - 1);

                    obj.save(value, key);

                }
            }
        }
    }
}
