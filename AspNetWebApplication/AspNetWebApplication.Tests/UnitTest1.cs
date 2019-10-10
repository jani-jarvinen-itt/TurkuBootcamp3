using System;
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
            int[] a = { 0, 100, -100, 100000, -100000 };
            int[] b = { 0, 200, -200, 200000, -200000 };

            Calculations calc = new Calculations();
            for (int indeksi = 0; indeksi < a.Length; indeksi++)
            {
                int luku1 = a[indeksi];
                int luku2 = b[indeksi];

                int sum = calc.Sum(luku1, luku2);

                int odotettu = luku1 + luku2;
                Assert.AreEqual(odotettu, sum);
            }
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
        public void TestaaOsamääränLaskenta()
        {
            Calculations calc = new Calculations();
            int a = 123;
            int b = 0;

            try
            {
                int osamäärä = calc.Osamäärä(a, b);

                Assert.Fail("Nollalla jakamisen tulee aiheuttaa poikkeus.");
            }
            catch (Exception ex)
            {
                if (!(ex is DivideByZeroException))
                {
                    Assert.Fail("Osamäärän laskenta ei onnistunut, "+
                        "mutta tuloksena ei ollut DivideByZero-poikkeusta.");
                }
            }

            //int odotettu = a / b;
            //Assert.AreEqual(odotettu, osamäärä);
        }
    }
}
