using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class InputHandler
    {
        public double ProcessingValueA(string a)
        {
            var result = ValidatingValuesAandB(a);
            while (!result)
            {
                Console.WriteLine("Введено некорректное значение");
                Console.Write("Введите a: ");
                a = Console.ReadLine();
                result = ValidatingValuesAandB(a);
            }
            return Convert.ToDouble(a);
        }

        public double ProcessingValueB(string b, string z)
        {
            var result = ValidatingValuesAandB(b);
            while (!result || Convert.ToDouble(b) == 0)
            {
                if (!result)
                {
                    Console.WriteLine("Введено некорректное значение");
                    Console.Write("Введите b: ");
                    b = Console.ReadLine();
                    result = ValidatingValuesAandB(b);
                    continue;
                }
                else if (DivisionByZeroCheck(b, z))
                {
                    Console.WriteLine("На ноль делить нельзя");
                    Console.Write("Введите b: ");
                    b = Console.ReadLine();
                    result = ValidatingValuesAandB(b);
                }
                else break;
            }
            return Convert.ToDouble(b);
        }

        public string ProcessingValueZ(string z)
        {
            while (!ValidatingValuesZ(z))
            {
                Console.WriteLine("Введен некорректный символ");
                Console.Write("Введите действие (+, -, *, /): ");
                z = Convert.ToString(Console.ReadLine());
            }
            return z;
        }

        public bool ValidatingValuesAandB(string z)
        {
            double x;
            if (!z.Contains(' '))
                return double.TryParse(z, out x);
            else return false;
        }

        public bool ValidatingValuesZ(string z)
        {
            if (z != "+" && z != "-" && z != "/" && z != "*")
                return false;
            else return true;
        }

        public bool DivisionByZeroCheck(string z, string y)
        {
            if (Convert.ToDouble(z) == 0 && y == "/")
                return true;
            else return false;
        }
    }
}
