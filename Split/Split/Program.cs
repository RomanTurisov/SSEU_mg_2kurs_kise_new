using System;
using System.Collections.Generic;
using System.Text;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через ;");
            string numbersStr = Console.ReadLine();
            //разбить строку по символу ;
            string[] numbersStrArr = numbersStr.Split(';');
            //массив чисел той же длинны, что и массив строк
            double[] numbersArr = new double[numbersStrArr.Length];
            //для каждого элемента массива
            int n = 0;
            for (int i = 0; i < numbersStrArr.Length; i++)
            {
                //преобразуем строки пробелов в числа
                if (double.TryParse(numbersStrArr[i].Trim(), out numbersArr[n])) 
                {
                    n++;
                };
            };
            //для каждого элемента массива
            for (int i = 0; i < numbersArr.Length; i++)
            {
                //вывести на экран
                Console.WriteLine("число[" + i + "] = " + numbersArr[i]);
            };
            //временный массив длиной n
            double[] buffer = new double[n];
            for (int i = 0; i < n; i++)
            {
                //копируем в буфер
                buffer[i] = numbersArr[i];
            };
            //копируем получившийся массив из буфера в numbersArr
            numbersArr = buffer;
            Console.ReadKey();
        }
    }
}
