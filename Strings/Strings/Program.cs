using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            char key; //нажатая клавиша
            string txt = ""; //обрабатываемая строка
            //повторять
            do
            {
                //очистка окна
                Console.Clear();
                //вывод строки и ее длины
                Console.WriteLine("Строка: " + txt);
                Console.WriteLine("Длина: " + txt.Length);
                //вывод меню
                Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
                Console.WriteLine("\t\t\t╔══════════════════════════╗");
                Console.WriteLine("\t\t\t║           МЕНЮ           ║");
                Console.WriteLine("\t\t\t║ 1 - ввести новую строку  ║");
                Console.WriteLine("\t\t\t║ 2 - поиск                ║");
                Console.WriteLine("\t\t\t║ 3 - замена               ║");
                Console.WriteLine("\t\t\t║ 4 - удаление             ║");
                Console.WriteLine("\t\t\t║ 5 - вставка              ║");
                Console.WriteLine("\t\t\t║ 6 - обрезка              ║");
                Console.WriteLine("\t\t\t║ ESC - выход              ║");
                Console.WriteLine("\t\t\t╚══════════════════════════╝");
                //считать нажатую клавишу
                key = Console.ReadKey().KeyChar;
                //проверить клавишу
                switch (key)
                {
                    case '1': //ввод новой строки
                        Console.Clear();
                        Console.WriteLine("Введите новую строку:");
                        txt = Console.ReadLine();
                        break;
                    case '2': //поиск подстроки
                        Console.Clear();
                        Console.WriteLine("Строка: " + txt);
                        Console.WriteLine();
                        Console.WriteLine("Введите строку для поиска:");
                        string substr = Console.ReadLine();
                        //индекс подстроки
                        int pos = txt.IndexOf(substr);
                        //если индекс отрицательный - подстрока не найдена
                        if (pos >= 0)
                        {
                            Console.WriteLine("Подстрока найдена на символе: " + pos);
                            //вывод найденной подстроки с подсветкой
                            Console.Write(txt.Substring(0, pos));  //начало строки с обычным цветом
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(txt.Substring(pos, substr.Length));  //найденный текст красным
                            Console.ResetColor();
                            Console.WriteLine(txt.Substring(pos + substr.Length));  //конец строки обычным
                        }
                        else
                        {
                            Console.WriteLine("Подстрока не найдена!");
                        };
                        //возврат в главное меню
                        Console.Write("Нажмите на любую клавишу для возварата в главное меню...");
                        Console.ReadKey();
                        break;
                    case '3': //замена подстроки
                        Console.Clear();
                        Console.WriteLine("Строка: " + txt);
                        Console.WriteLine();
                        Console.WriteLine("Введите подстроку для поиска:");
                        string substrOld = Console.ReadLine();
                        Console.WriteLine("Введите подстроку для замены:");
                        string substrNew = Console.ReadLine();
                        //выполнить замену
                        txt = txt.Replace(substrOld, substrNew);
                        //возвар в главное меню
                        Console.Write("Нажмите на любую клавишу для возварата в главное меню...");
                        Console.ReadKey();
                        break;
                    case '4': //удаление подстроки
                        Console.Clear();
                        Console.WriteLine("Строка: " + txt);
                        Console.WriteLine();
                        Console.WriteLine("Введите подстроку для удаления:");
                        string substrDel = Console.ReadLine();
                        //выполнить замену на пустую строку
                        txt = txt.Replace(substrDel, "");
                        //возврат в главное меню
                        Console.Write("Нажмите на любую клавишу для возварата в главное меню...");
                        Console.ReadKey();
                        break;
                    case '5': //вставка подстроки
                        Console.Clear();
                        Console.WriteLine("Строка: " + txt);
                        Console.WriteLine();
                        Console.WriteLine("Введите подстроку для вставки:");
                        string substrIns = Console.ReadLine();
                        Console.WriteLine("После какого символа вставить:");
                        //если введена корректная позиция
                        if (int.TryParse(Console.ReadLine(), out pos) && pos < txt.Length)
                        {
                            //вставить подстроку
                            txt = txt.Insert(pos, substrIns);
                        }
                        else
                        {
                            Console.WriteLine("Ошибка! Номер символа должен быть числом не более длины строки.");
                        };
                        //возврат в главное меню
                        Console.Write("Нажмите на любую клавишу для возварата в главное меню...");
                        Console.ReadKey();
                        break;
                    case '6': //обрезка строки
                        Console.Clear();
                        Console.WriteLine("Строка: " + txt);
                        Console.WriteLine();
                        Console.WriteLine("После какого символа удалить:");
                        //если введена корректная позиция
                        if (int.TryParse(Console.ReadLine(), out pos) && pos < txt.Length)
                        {
                            //ввести количество символов
                            int len;
                            Console.WriteLine("Сколько символов удалить:");
                            if (int.TryParse(Console.ReadLine(), out len))
                            {
                                //удалить часть строки
                                txt = txt.Remove(pos, len);
                            }
                            else
                            {
                                Console.WriteLine("Ошибка! Длина должна быть целым числом.");
                            };
                        }
                        else
                        {
                            Console.WriteLine("Ошибка! Номер символа должен быть числом не более длины строки.");
                        };
                        //возврат в главное меню
                        Console.Write("Нажмите на любую клавишу для возварата в главное меню...");
                        Console.ReadKey();
                        break;
                };
            }
            while (key != (char)27); //пока не нажат ESC
        }
    }
}
