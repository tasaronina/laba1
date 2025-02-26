using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstApp;

namespace FirstApp.Tests
{
    [TestClass()]
    public class LogicaTests
    {
        [TestMethod()]
        public void TestOne()
        {
            var number = 354;
            var result = Logica.FindLargestDigit(number);
            Assert.AreEqual(5, result);
        }

        [TestMethod()]
        public void TestTwo()
        {
            var number = 32;
            var result = Logica.IsThreeDigitNumber(number);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void TestThree()
        {
            var number = 222;
            var result = Logica.AllDigitsEqual(number);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void TestFour()
        {
            var number = 123;
            var result = Logica.AllDigitsEqual(number);
            Assert.IsFalse(result);
        }

    }
}
