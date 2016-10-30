using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayMax
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод длины массива
            int n;
            do
            {
                Console.WriteLine("¬ведите длину массива: ");
            }
            while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0));
            //инициализаци€ массива
            int[] a = new int[n];
            //ввод значений массива
            int i = 0;
            while (i < n)
            {
                Console.WriteLine("¬ведите а[" + i + "]: ");
                if (int.TryParse(Console.ReadLine(), out a[i]))
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("¬ведите целое число!");
                }; ;
                //поиск максимального значени€
                int max = a[0];
                for (i = 1; i < a.Length; i++)
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                    };
                };
            };
            //выход из программы
            Console.ReadKey();
        }
    }
}
