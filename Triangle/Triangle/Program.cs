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
                    Console.WriteLine("����������� �������� �������������!");
                }
                else
                {
                    Console.WriteLine("�������. ���������� �� �������� �������������!");
                }
                Console.ReadKey();
            }
        }
    }
}
