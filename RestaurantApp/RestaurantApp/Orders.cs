using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Restaurantte
{

    class Orders
    {

        private static Dictionary<string, int> order_dict = new Dictionary<string, int>();


        public void save(int val,string key)
        {
            order_dict.Add(key,val);
        }


        public void bill()
        {
            int count = 1;int total = 0;
            Console.WriteLine("\n Bill: \n");
            foreach (KeyValuePair<string, int> i in order_dict)
            {
                Console.WriteLine(count++ + "." + i.Key.ToString() + "  =  " + i.Value.ToString());
                total += i.Value;
                Console.WriteLine();
            }

            Console.WriteLine("\n Total:" + total);
            Console.Read();
        }
        
        
    }
}
