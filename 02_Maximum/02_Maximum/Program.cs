using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            if (int.TryParse(Console.ReadLine(), out A))
            {
                if (int.TryParse(Console.ReadLine(), out B))
                {
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
                }
                else
                {
                    Console.WriteLine("Неверное значение! Нужно ввести целое число.");
                };
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
