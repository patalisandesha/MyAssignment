using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_Class_Hierarchy
{
    class Rectangle : Quadrilateral 
    {
        public Rectangle(int length, int breadth)
        {
            base.side1 = base.side3 = length;
            base.side2 = base.side4 = breadth;
        }
        
        public override float Area()
        {
            return base.side1 * base.side2;
        }
    }
}
