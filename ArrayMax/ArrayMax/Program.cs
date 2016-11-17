using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите длину массива: ");
            int.TryParse(Console.ReadLine(), out n);
            int[] a = new int[n];
            //ввод значений массива
            //поиск максимального значения
            int i = 0;
            int max = int.MinValue;
            int iMax = 0;
            while (i < n)
            {
                Console.Write("Введите а[" + i + "]: ");
                if (int.TryParse(Console.ReadLine(), out a[i]))
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                        iMax = i;
                    };
                    i++;
                }
                else
                {
                    Console.WriteLine("Введите целое число!");
                };
            };
            //вывод результата
            Console.Write("Максимальное значение: " + max);
            //выход из программы
            Console.ReadKey();
        }
    }
}
