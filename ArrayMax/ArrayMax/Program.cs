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
                Console.WriteLine("Введите длину массива: ");
            }
            while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0));
            //инициализация массива
            int[] a = new int[n];
            //ввод значений массива
            int i = 0;
            while (i < n)
            {
                Console.WriteLine("Введите а[" + i + "]: ");
                if (int.TryParse(Console.ReadLine(), out a[i]))
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("Введите целое число!");
                }; 
            };
            //поиск максимального значения
            int max = a[0];
            for (i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                };
            };
            //вывод результата
            Console.WriteLine("Максимальное значение: " + max);
            //выход из программы
            Console.ReadKey();
        }
    }
}
