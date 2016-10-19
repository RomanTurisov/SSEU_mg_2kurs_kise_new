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
                //если A >= B
                if (A >= B)
                {
                    //и если A>= C
                    if (A >= C)
                    {
                        Max = A;
                    }
                    //иначе - C >= A
                    else
                    {
                        Max = C;
                    }
                }
                //иначе больше B
                else
                {
                    //и если B >= C
                    if (B >= C)
                    {
                        //то максимальное - B
                        Max = B;
                    }
                    //иначе - C > B
                    else
                    {
                        //максимальное C
                        Max = C;
                    }
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
