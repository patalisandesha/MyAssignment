using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_Class_Hierarchy
{
    class Square :  Quadrilateral 
    {
        public Square(int side)
        {
            base.side1 = base.side2 = base.side3 = base.side4 = side;
        }

        public override float Area()
        {
            return base.side1 * base.side1;
        }
    }
}
