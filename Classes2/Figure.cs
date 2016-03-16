using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes2
{
    public class Figure
    {
        Point[] PointArray;
      
        public Figure(Point[] points)
        {            
            PointArray = new Point[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                this.PointArray[i] = points[i];
            }             
        }      

        public double LenghtSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }

        public double PerimetrCalculator()
        {
            double perimetr = 0;
            for (int i = 0; i < PointArray.Length-1; i++)
            {
                perimetr += LenghtSide(PointArray[i], PointArray[i+1]);
            }
            perimetr += LenghtSide(PointArray[0], PointArray[PointArray.Length-1]);
            
            for (int i = 0; i < PointArray.Length; i++)
                Console.Write(this.PointArray[i].Name);
            Console.WriteLine(" perimetr = {0}", perimetr);
            return perimetr;
        }
    }
}


