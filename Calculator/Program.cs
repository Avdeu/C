using Calculator;
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
                string c;
                Calcul k = new Calcul();
                InputHandler n = new InputHandler();

                Console.Write("Введите a: ");
                a = n.ProcessingValueA(Console.ReadLine());

                Console.Write("Введите действие (+, -, *, /): ");
                c = n.ProcessingValueZ(Console.ReadLine());
                
                Console.Write("Введите b: ");
                b = n.ProcessingValueB(Console.ReadLine(), c);

                if (c == "+")
                    Conclusion(k.Addition(a, b));
                else if (c == "-")
                    Conclusion(k.Subtraction(a, b));
                else if (c == "*")
                    Conclusion(k.Multiplication(a, b));
                else if (c == "/")
                    Conclusion(k.Division(a, b));
            }
        }

        static void Conclusion(double a)
        {
            Console.WriteLine("Ответ:" + a);
            Console.WriteLine();
        }
    }
}
