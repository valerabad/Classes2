using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classes2
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void PropertyTestAdress()
        {
            Adress adress = new  Adress ("Ukraine", "Dnepr", 49000, "Lenina", 31, 22);

            string expectedCountry = "Ukraine";
            string expectedCity = "Dnepr";
            int expectedApart = 22;
            int expectedHouse = 31;
            string expectedStreet = "Lenina";
            int expectedindex = 49000;

            Assert.AreEqual(expectedCity, adress.City);
            Assert.AreEqual(expectedCountry, adress.Country);
            Assert.AreEqual(expectedApart, adress.Apartment);
            Assert.AreEqual(expectedindex, adress.Index);
            Assert.AreEqual(expectedStreet, adress.Street);
            Assert.AreEqual(expectedHouse, adress.House);

        }

        [TestMethod]
        public void PropertyTestAdressReturnNULL()
        {
            Adress adress = new Adress(null, null, 49000, null, 31, 22);
            Assert.IsNull(adress.Country);
            Assert.IsNull(adress.City);
            Assert.IsNull(adress.Street);
        }
    }
}
