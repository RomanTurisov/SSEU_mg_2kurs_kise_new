using System;
using System.Collections.Generic;
using System.Text;

namespace Cel_Far
{
    class Program
    {
        static void Main(string[] args)
        {
            //объ€вление переменных
            double cel;
            double.TryParse(Console.ReadLine(), out cel);
            //преобразование градусов ÷ельси€ в градусы ‘аренгейта
            double celfar = (cel * 1.8) + 32;
            //вывод результата
            Console.WriteLine(celfar + " градусов ‘аренгейта");
            Console.ReadKey();
        }
    }
}
