using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_Class_Hierarchy
{
    abstract class Quadrilateral : GeometricSymbols 
    {
        protected int side1, side2, side3, side4;

        protected Quadrilateral()
        {
            this.side1 = this.side2 = this.side3 = this.side4 = 0;
        }

        public override abstract float Area();

        public override float Perimeter
        {
            get 
            {
                return this.side1 + this.side2 + this.side3 + this.side4;
            }
        }
    }
}
