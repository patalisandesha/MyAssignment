using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_Class_Hierarchy
{
    abstract class GeometricSymbols
    {
        abstract public float Area();
        abstract public float Perimeter { get; }
    }
}
