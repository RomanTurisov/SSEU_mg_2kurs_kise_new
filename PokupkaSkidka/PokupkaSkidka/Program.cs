using System;
using System.Collections.Generic;
using System.Text;

namespace PokupkaSkidka
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum;
            double.TryParse(Console.ReadLine(), out sum);
            //если сумма покупки больше 1000р
            if (sum >= 1000)
            {
                double disc = sum - ( sum * 15 / 100 );
                //вывод результата
                Console.WriteLine("Сумма покупки с учетом скидки 15% = " + disc);
            }
            //в противоположном случае - скидки нет
            else
            {
                Console.WriteLine("Сумма покупки меньше 1000р. Скидка не предоставляется!");
            };
            Console.ReadKey();
        }
    }
}
