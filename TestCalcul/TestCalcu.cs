using CCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestCalcul
{
    [TestClass]
    public class TestCalcu
    {
        [TestMethod]
        public void TestAddition()
        {
            Calculator cc = new Calculator();
            double a = -1.3;
            double b = 2.5;
            var result = cc.Addition(a, b);
            var expect = 1.2;
            Assert.AreEqual(result, expect);
        }

        [TestMethod]
        public void TestSub()
        {
            Calculator cc = new Calculator();
            double a = 5;
            double b = -2.125;
            var result = cc.Subtraction(a, b);
            var expect = 7.125;
            Assert.AreEqual(result, expect);
        }

        [TestMethod]
        public void TestMultipli()
        {
            Calculator cc = new Calculator();
            double a = 2.5;
            double b = 2;
            var result = cc.Multiplication(a, b);
            var expect = 5;
            Assert.AreEqual(result, expect);
        }

        [TestMethod]
        public void TestMultipli0()
        {
            Calculator cc = new Calculator();
            double a = 2.5;
            double b = 0;
            var result = cc.Multiplication(a, b);
            var expect = 0;
            Assert.AreEqual(result, expect);
        }

        [TestMethod]
        public void TestDivision()
        {
            Calculator cc = new Calculator();
            double a = 5;
            double b = 2;
            var result = cc.Division(a, b);
            var expect = 2.5;
            Assert.AreEqual(result, expect);
        }

        [TestMethod]
        public void TestDivision0()
        {
            Calculator cc = new Calculator();
            double a = 0;
            double b = 2;
            var result = cc.Division(a, b);
            var expect = 0;
            Assert.AreEqual(result, expect);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException),
            "Деление на ноль запрещено")]
        public void TestDivisionZero()
        {
            Calculator cc = new Calculator();
            double a = 5;
            double b = 0.0;
            var result = cc.Division(a, b);
        }
    }
}
