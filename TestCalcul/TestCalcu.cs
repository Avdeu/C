using Calculator;
using CCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestCalcul
{
    [TestClass]
    public class TestCalcu
    {

        [TestMethod]
        public void TestAddition() // Проверка сложения с использованием отрицательных чисел
        {
            Calcul cc = new Calcul();
            double a = -1.3;
            double b = 2.5;
            var result = cc.Addition(a, b);
            var expect = 1.2;
            Assert.AreEqual(result, expect);
        }

        [TestMethod]
        public void TestSub() // Проверка вычитания с использованием отрицательных чисел
        {
            Calcul cc = new Calcul();
            double a = 5;
            double b = -2.125;
            var result = cc.Subtraction(a, b);
            var expect = 7.125;
            Assert.AreEqual(result, expect);
        }

        [TestMethod]
        public void TestMultipli() // Проверка умножения
        {
            Calcul cc = new Calcul();
            double a = 2.5;
            double b = 2;
            var result = cc.Multiplication(a, b);
            var expect = 5;
            Assert.AreEqual(result, expect);
        }

        [TestMethod]
        public void TestMultipli0() // Получаем очень большое значение
        {
            Calcul cc = new Calcul();
            double a = 999999999999999;
            double b = 999999999999999;
            var result = cc.Multiplication(a, b);
            var expect = 9.99999999999998E+29;
            Assert.AreEqual(result, expect);
        }

        [TestMethod]
        public void TestMultipliByZero() // Проверка умножения на ноль и умножение нуля
        {
            Calcul cc = new Calcul();
            double a = 2.5;
            double b = 0;
            var result = cc.Multiplication(a, b);
            var result1 = cc.Multiplication(b, a);
            var expect = 0;
            Assert.AreEqual(result, expect);
            Assert.AreEqual(result1, expect);
        }

        [TestMethod]
        public void TestDivision() // Проверка деления
        {
            Calcul cc = new Calcul();
            double a = 5;
            double b = 2;
            var result = cc.Division(a, b);
            var expect = 2.5;
            Assert.AreEqual(result, expect);
        }

        [TestMethod]
        public void TestDivision0() // Получаем очень маленькое значение
        {
            Calcul cc = new Calcul();
            double a = 1;
            double b = 999999999999999;
            var result = cc.Division(a, b);
            var expect = 1.000000000000001E-15;
            Assert.AreEqual(result, expect);
        }

        [TestMethod]
        public void TestZeroDivision() // Проверка деления нуля
        {
            Calcul cc = new Calcul();
            double a = 0;
            double b = 2;
            var result = cc.Division(a, b);
            var expect = 0;
            Assert.AreEqual(result, expect);
        }

        [TestMethod]
        public void TestDivisionByZero()  // проверка деления на ноль
        {
            InputHandler k = new InputHandler();
            string b = "0,0";
            string a = "/";
            var expect = k.DivisionByZeroCheck(b, a);
            var result = true;
            Assert.AreEqual(result, expect);
        }

        [TestMethod]
        public void TestForIncorrectValueAandB() // проверка на введение некорректного значения в А или B
        {
            InputHandler k = new InputHandler();
            var ab = "ad0";
            var result = k.ValidatingValuesAandB(ab);
            var expect = false;
            Assert.AreEqual(result, expect);
        }

        [TestMethod]
        public void TestForIncorrectValueAandB1() // проверка на введение некорректного числа с пробелом в середине/конце/начале или ввод пробела
        {
            InputHandler k = new InputHandler();
            var ab = " ";
            var ab0 = "123 45";
            var ab1 = "123 45";
            var ab2 = "123 45";
            var result = k.ValidatingValuesAandB(ab);
            var result0 = k.ValidatingValuesAandB(ab0);
            var result1 = k.ValidatingValuesAandB(ab1);
            var result2 = k.ValidatingValuesAandB(ab2);
            var expect = false;
            Assert.AreEqual(result, expect);
            Assert.AreEqual(result0, expect);
            Assert.AreEqual(result1, expect);
            Assert.AreEqual(result2, expect);
        }

        [TestMethod]
        public void TestForIncorrectValueAandB2() // проверка на введение некорректного числа с несколькими запятыми
        {
            InputHandler k = new InputHandler();
            var ab = "1,234,5";
            var result = k.ValidatingValuesAandB(ab);
            var expect = false;
            Assert.AreEqual(result, expect);
        }

        [TestMethod]
        public void TestForIncorrectValueAandBandZ() // проверка на ввод пустого значения
        {
            InputHandler k = new InputHandler();
            var abz = "";
            var result = k.ValidatingValuesAandB(abz);
            var result1 = k.ValidatingValuesZ(abz);
            var expect = false;
            Assert.AreEqual(result, expect);
            Assert.AreEqual(result1, expect);
        }

        [TestMethod]
        public void TestValidationOfTheArithmeticSign0() // Проверка на ввод некорректного значения
        {
            InputHandler k = new InputHandler();
            var b = "ыва5";
            var result = k.ValidatingValuesZ(b);
            var expect = false;
            Assert.AreEqual(result, expect);
        }

        [TestMethod]
        public void TestValidationOfTheArithmeticSign1() // Проверка на ввод некорректного арифметического знака (символ, но не из допустимых)
        {
            InputHandler k = new InputHandler();
            var b = ".";
            var result = k.ValidatingValuesZ(b);
            var expect = false;
            Assert.AreEqual(result, expect);
        }

        [TestMethod]
        public void TestValidationOfTheArithmeticSign2() // Проверка на одновременный ввод двух и более арифметических знака
        {
            InputHandler k = new InputHandler();
            var b = "/*";
            var result = k.ValidatingValuesZ(b);
            var expect = false;
            Assert.AreEqual(result, expect);
        }

    }
}
