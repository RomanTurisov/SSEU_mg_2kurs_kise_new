using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            if (int.TryParse(Console.ReadLine(), out A)&& int.TryParse(Console.ReadLine(), out B) && int.TryParse(Console.ReadLine(), out C))
                {
                //максимальное значение
                int Max;
                //если больше A
                if (A >= B)
                {
                    Max = A;
                }
                //иначе - больше В
                else 
                {
                    Max = B;
                }
                //если C больше максимального из А, В, то С - максимальное
                if (C >= Max)
                {
                    Max = C;
                };
                    //вывод результата
                    Console.WriteLine("Максимальное = " + Max);
                }
                else
                {
                    Console.WriteLine("Неверное значение! Нужно ввести целое число.");
                };
            //завершение программы
            Console.ReadKey();
        }
    }
}
