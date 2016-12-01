using System;
using System.Collections.Generic;
using System.Text;

namespace Identificator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool noErrors = true; //нет ошибок, по умолчанию
            Console.WriteLine("Введите индентификатор:");
            string id = Console.ReadLine(); //индентификатор
            //проверка первого символа
            if (!((id[0] >= 'a') && (id[0] <= 'z') //не строчная буква
                || (id[0] >= 'A') && (id[0] <= 'Z') //или заглавная буква
                || (id[0] == '_'))) //или подчеркивание
            {
                noErrors = false;
                Console.WriteLine("Первый символ должен быть буквой или знаком подчеркивания!");
            };
            //проверка остальных символов
            for (int i = 1; i < id.Length; i++)
            {
                //првоерка i-того символа
                if (!((id[i] >= 'a') && (id[i] <= 'z') //не строчная буква
                    || (id[i] >= 'A') && (id[i] <= 'Z') //или заглавная буква
                    || (id[i] >= '0') && (id[i] <= '9') //или цифра
                    || (id[i] == '_'))) //или подчеркивание
                {
                    noErrors = false;
                    Console.WriteLine("Символ" + i + "(" + id[i]
                        + ")" + " должен быть буквой, цифрой или знаком подчеркивания!");
                };
            };
            if (noErrors)
            {
                Console.WriteLine("Индентификатор верный.");
            };
            Console.ReadKey();
        }
    }
}
