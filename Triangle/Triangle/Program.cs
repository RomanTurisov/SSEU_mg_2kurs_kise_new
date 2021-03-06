using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            if (double.TryParse(Console.ReadLine(), out a) &&
                double.TryParse(Console.ReadLine(), out b) &&
                double.TryParse(Console.ReadLine(), out c))
            {
                if ((a < b + c) && (b < a + c) && (c < a + b))
                {
                    Console.WriteLine("Треугольник является невырожденным.");
                }
                else
                {
                    Console.WriteLine("Треугольник является вырожденным.");
                }
                if ((a == b) && (a == c) && (c == b))
                {
                    Console.WriteLine("Треугольник является равносторонним.");
                }
                else
                {
                    Console.WriteLine("Треуголник НЕ является равносторонним.");
                }
                if ((a == b) || (a == c) || (c == b))
                {
                    Console.WriteLine("Треугольник является равнобедренным.");
                }
                else
                {
                    Console.WriteLine("Треугольник НЕ является равнобедренным.");
                }
            };
                Console.ReadKey();
        }
    }
}
