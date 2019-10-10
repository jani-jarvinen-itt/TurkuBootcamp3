using AspNetWebApplication.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetWebApplication.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestaaSummanLaskenta()
        {
            Calculations calc = new Calculations();
            int a = 123;
            int b = 234;

            int sum = calc.Sum(a, b);

            int odotettu = a + b;
            Assert.AreEqual(odotettu, sum);
        }

        [TestMethod]
        public void TestaaErotuksenLaskenta()
        {
            Calculations calc = new Calculations();
            int a = 123;
            int b = 234;

            int erotus = calc.Erotus(a, b);

            int odotettu = a - b;
            Assert.AreEqual(odotettu, erotus);
        }

        [TestMethod]
        public void TestaaTulonLaskenta()
        {
            Calculations calc = new Calculations();
            int a = 123;
            int b = 234;

            int tulo = calc.Tulo(a, b);

            int odotettu = a * b;
            Assert.AreEqual(odotettu, tulo);
        }

        [TestMethod]
        public void TestaaOsam‰‰r‰nLaskenta()
        {
            Calculations calc = new Calculations();
            int a = 123;
            int b = 234;

            int osam‰‰r‰ = calc.Osam‰‰r‰(a, b);

            int odotettu = a / b;
            Assert.AreEqual(odotettu, osam‰‰r‰);
        }
    }
}
