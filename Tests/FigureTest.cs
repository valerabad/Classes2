using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classes2
{
    [TestClass]
    public class FigureTest
    {
        double actual;
        double expected;

        [TestMethod]
        public void LengthSideTest()
        {
            Point[] points = new Point[3];
            points[0] = new Point(3, -1, "testPoint1");
            points[1] = new Point(-2, 2, "testPoint2");
            Figure figure = new Figure(points);
            actual = figure.LenghtSide(points[0], points[1]);
            expected = Math.Sqrt(34);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PerimetrTest()
        {
            Point[] p4 = new Point[4];
            p4[0] = new Point(1, 2, "testPoint1");
            p4[1] = new Point(1, 4, "testPoint3");
            p4[2] = new Point(3, 4, "testPoint4");
            p4[3] = new Point(3, 2, "testPoint2");
      
            Figure figure = new Figure(p4);
            actual = figure.PerimetrCalculator();
            expected = 8;
            Assert.AreEqual(actual, expected);                       
        }
    }
}
