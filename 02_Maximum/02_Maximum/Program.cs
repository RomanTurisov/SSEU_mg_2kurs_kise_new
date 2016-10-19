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
                //если больше остальных
                if ((A >= B) && (A >= C))
                {
                    Max = A;
                }
                //иначе, если В больше остальных
                else if ((B >= A) && (B >= C))
                {
                    Max = B;
                }
                //иначе остается C
                else
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
