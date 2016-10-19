using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод исохдных значений
            int A, B;
            int.TryParse(Console.ReadLine(), out A);
            int.TryParse(Console.ReadLine(), out B);
            //максимальное значение
            int Max;
            //если больше А
            if (A >= B)
            {
                Max = A;
            }
            //иначе - больше В
            else
            {
                Max = B;
            };
            //вывод результата
            Console.WriteLine("Максимальное = " + Max);
            //завершение программы
            Console.ReadKey();
        }
    }
}
