namespace cs_con_Class_Hierarchy
{
    internal class Circle //It is not comes under the Quadrilateral hence this class not inherit from Quadrilateral
    {
        public int radius;
        public Circle(int r)
        {
            this.radius = r;
        }

        public double CirclePer()
        {
            return 2 * 3.12 * radius;
        }
        public double CirclArea()
        {
            return 3.12 * radius * radius;
        }
    }
}