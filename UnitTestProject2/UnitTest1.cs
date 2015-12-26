using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Kata;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
      //  randomly testing the basic numbers
        [TestMethod]
         public void Test_I()
        {
            RomanNumeral obj = new RomanNumeral();
            var output = obj.Generate(1);

            Assert.AreEqual(output, "I");
        }



        [TestMethod]
        public void Test_5()
        {
            RomanNumeral obj = new RomanNumeral();
            var output = obj.Generate(5);

            Assert.AreEqual(output, "V");
        }



        [TestMethod]
        public void Test_IX()
        {
            RomanNumeral obj = new RomanNumeral();
            var output = obj.Generate(9);

            Assert.AreEqual(output, "IX");
        }

        [TestMethod]
        public void Test_X()
        {
            RomanNumeral obj = new RomanNumeral();
            var output = obj.Generate(10);

            Assert.AreEqual(output, "X");
        }


        [TestMethod]
        public void Test_L()
        {
            RomanNumeral obj = new RomanNumeral();
            var output = obj.Generate(50);

            Assert.AreEqual(output, "L");
        }


        [TestMethod]
        public void Test_C()
        {
            RomanNumeral obj = new RomanNumeral();
            var output = obj.Generate(100);

            Assert.AreEqual(output, "C");
        }

        [TestMethod]
        public void Test_MMMCMXCIX()
        {
            RomanNumeral obj = new RomanNumeral();
            var output = obj.Generate(3999);

            Assert.AreEqual(output, "MMMCMXCIX");
        }




















    }
}
