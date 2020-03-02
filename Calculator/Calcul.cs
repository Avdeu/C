using System;
using System.Collections.Generic;
using System.Text;

namespace CCalculator
{
    public class Calculator
    {
        public double Addition(double a, double b)
        {
            return a + b;
        }

        public double Subtraction(double a, double b)
        {
            return a - b;
        }

        public double Multiplication(double a, double b)
        {
            return a * b;
        }

        public double Division(double a, double b)
        {
            if(b == 0.0d)
                throw new DivideByZeroException("Деление на ноль запрещено");
            return a / b;
        }
    }
}
