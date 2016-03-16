using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes2
{
    public class Rectangle
    {
        double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            if (side1 >= 0 && side2 >= 0)
                return side1 * side2;
            else
                return -1;
        }

        public double PerimetrCalculator()
        {
            double res = (side1 >= 0 && side2 >= 0) ? 2.0d * (side1 + side2) : -1;
            return res;
        }

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimetr
        {
            get
            {
                return PerimetrCalculator();
            }
        }


    }
}
