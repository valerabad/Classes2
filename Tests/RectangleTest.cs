using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classes2
{
    [TestClass]
    public class RectangleTests
    {
        double expSide1 = 5, expSide2 = 10, expArea = 50, expPerimetr = 30, actual;
        [TestMethod]
        public void TestArea()
        {
            Rectangle rectangle = new Rectangle(expSide1, expSide2);
            actual = rectangle.AreaCalculator();
            Assert.AreEqual(expArea, actual);
            rectangle = new Rectangle(-1, -9);
            actual = rectangle.AreaCalculator();
            Assert.AreEqual(-1, actual);
        }

        [TestMethod]
        public void TestPerimetr()
        {
            Rectangle rectangle = new Rectangle(expSide1, expSide2);
            actual = rectangle.PerimetrCalculator();
            Assert.AreEqual(expPerimetr, actual);
            rectangle = new Rectangle(-1, -9);
            actual = rectangle.PerimetrCalculator();
            Assert.AreEqual(-1, actual);
        }

    }
}
