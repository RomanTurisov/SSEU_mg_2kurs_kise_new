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
            int x; //одно число
            Console.Write("Введите количество чисел для суммирования: ");
            if (int.TryParse(Console.ReadLine(), out N))
            {
                int Sum = 0; //сумма чисел
                //N раз
                for (int i = 0; i < N; i++)
                {
                    Console.Write("Введите число: ");
                    //если введено корректное число
                    if (int.TryParse(Console.ReadLine(), out x))
                    {
                        Sum += x; //добавить к сумме
                        /*DEBUG INFO
                        Console.WriteLine("{" + Sum + "}");
                        //*/
                    }
                    else
                    {
                        Console.WriteLine("Неверное значение! Вводите целые числа!");
                        i--;
                    };
                };
                //вывод результата
                Console.WriteLine("Сумма: " + Sum);
            };
            //завершение программы
            Console.ReadKey();
        }
    }
}
