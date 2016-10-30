using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N; //количество чисел
            int F = 1;
            Console.WriteLine("Введите число для вычисления факториала: ");
            N = int.Parse(Console.ReadLine());
            for (int c = N; c > 1; c--)
                F = F * c;
            Console.WriteLine("Факториал " + N + "! = " + F);
            //завершение программы
            Console.ReadLine();
        }
    }
}
