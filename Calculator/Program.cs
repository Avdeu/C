using System;

namespace CCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double a, b;
                char z;
                Calculator cc = new Calculator();
                Console.Write("Введите a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите действие (+, -, *, /): ");
                z = Convert.ToChar(Console.ReadLine());
                if (z != '+' && z != '-' && z != '/' && z != '*')
                    Console.WriteLine("Введен некорректный символ");
                else
                {
                    Console.Write("Введите b: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    if (z == '+')
                        Conclusion(cc.Addition(a, b));
                    else if (z == '-')
                        Conclusion(cc.Subtraction(a, b));
                    else if (z == '*')
                        Conclusion(cc.Multiplication(a, b));
                    else if (z == '/')
                        Conclusion(cc.Division(a, b));
                }
            }
        }
        static void Conclusion(double a)
        {
            Console.WriteLine("Ответ:" + a);
            Console.WriteLine();
        }
    }
}
