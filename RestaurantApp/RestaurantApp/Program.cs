using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantte
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n Welcome to my restaurant! \n");

            int flag = 1;
            int s;
            int selection=0;

            while (flag !=0)
            { 

                Console.WriteLine("\n Welcome.. Select category \n");
                Console.WriteLine(" 1.Main Dish ");
                Console.WriteLine(" 2.Side Dish ");
                Console.WriteLine(" 3.Desserts ");
                Console.WriteLine(" 4.Proceed to Bill \n");
                MainDish object1 = new MainDish();
                SideDish object2 = new SideDish();
                Desserts object3 = new Desserts();
                Orders object4 = new Orders();
                selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:

                         s=object1.items();
                        if (s == 1)
                            flag = 0;
                        break;
                    case 2:
                        s = object2.items();
                        if (s == 1)
                            flag = 0;
                        break;
                    case 3:
                        s = object3.items();
                        if (s == 1)
                            flag = 0;
                        break;
                    case 4:
                        object4.bill();
                        flag = 0;
                        break;
                    default:
                        Console.WriteLine("\n Please select a valid option\n");
                        break;
                }

                

            }
        }
    }
}
