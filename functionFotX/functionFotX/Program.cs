using System;
using System.Collections.Generic;
using System.Text;

namespace functionFotX
{
    class Program
    {
        static void Main(string[] args)
        {
            //объ€вление переменных
            double x;
            double.TryParse(Console.ReadLine(), out x);
            //вычисление значени€ функции f(x)
            double func = - x / 23 * Math.Sqrt((Math.Pow(x, 2)) + 2 * x) + 1992;
            //вывод результата
            Console.WriteLine("«начение функции f(x) = " + func);
            Console.ReadKey();
        }
    }
}
