using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_Class_Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle objRect = new Rectangle(10, 20);
            System.Console.WriteLine("RECTANGLE : Perimeter {0}, Area {1}",
                    objRect.Perimeter, objRect.Area());

            Square objSquare = new Square(5);
            System.Console.WriteLine("SQUARE : Perimeter {0}, Area {1}",
                    objSquare.Perimeter, objSquare.Area());
            Circle ObjCircle = new Circle(5);
            System.Console.WriteLine("Circle: Perimeter {0},Area{1}",
                ObjCircle.CirclePer(), ObjCircle.CirclArea());

        }
    }
}
