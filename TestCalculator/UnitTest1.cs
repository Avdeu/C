using CCalculator;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestCalculator
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestAddition()
        {
            Calculator cc = new Calculator();
            double a = 1.3;
            double b = 2.5;
            var result = cc.Addition(a, b);
            var expect = 3.8;
            Assert.AreEqual(result, expect);
        }

        [Test]
        public void TestSub()
        {
            Calculator cc = new Calculator();
            double a = 5;
            double b = 2.125;
            var result = cc.Subtraction(a, b);
            var expect = 2.875;
            Assert.AreEqual(result, expect);
        }

        [Test]
        public void TestMultipli()
        {
            Calculator cc = new Calculator();
            double a = 2.5;
            double b = 2;
            var result = cc.Multiplication(a, b);
            var expect = 5;
            Assert.AreEqual(result, expect);
        }

        [Test]
        public void TestDivision()
        {
            Calculator cc = new Calculator();
            double a = 5;
            double b = 2;
            var result = cc.Division(a, b);
            var expect = 2.5;
            Assert.AreEqual(result, expect);
        }

        [Test]
        [ExpectedException(typeof(DivideByZeroException),
            "Oh my god, we can't divison on zero")]
        public void TestDivisionZero()
        {
            Calculator cc = new Calculator();
            double a = 5;
            double b = 0.0;
            var result = cc.Division(a, b);
            var expect = new DivideByZeroException("Деление на ноль запрещено");
            Assert.AreEqual(result, expect);
        }
    }
}