using System;
using System.Collections.Generic;
using System.Text;

namespace FIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string imya = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string otchestvo = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string familiya = Console.ReadLine();
            //И. О. Фамилия
            if (!string.IsNullOrEmpty(otchestvo))  //если отчество ввели
            {
                Console.WriteLine(imya[0].ToString().ToUpper() + ". "  //И.
                    + otchestvo[0].ToString().ToUpper() + ". "  //О.
                    + familiya[0].ToString().ToUpper()  //Ф
                    + familiya.Substring(1).ToLower());  //амилия
            }
            else //иначе отчество не ввели
            {
                //выводим без отчетсва
                Console.WriteLine(imya[0].ToString().ToUpper() + ". "  //И.
                    + familiya[0].ToString().ToUpper()  //Ф
                    + familiya.Substring(1).ToLower());  //амилия
            };
            //Фамилия И. О.
            if (!string.IsNullOrEmpty(otchestvo))  //если отчество ввели
            {
                Console.WriteLine(familiya[0].ToString().ToUpper()  //Ф
                    + familiya.Substring(1).ToLower() + " " //амилия
                    + imya[0].ToString().ToUpper() + ". "  //И.
                    + otchestvo[0].ToString().ToUpper() + ". ");  //О.
            }
            else  //иначе отчество не ввели
            {
                //выводим без отчетсва
                Console.WriteLine(familiya[0].ToString().ToUpper()  //Ф
                    + familiya.Substring(1).ToLower() + " " //амилия
                    + imya[0].ToString().ToUpper() + ". ");  //И.
            };
            //Имя Отчество ФАМИЛИЯ
            if (!string.IsNullOrEmpty(otchestvo))  //если отчество ввели
            {
                Console.WriteLine(imya[0].ToString().ToUpper()  //И
                    + imya.Substring(1).ToLower() + " " //мя
                    + otchestvo[0].ToString().ToUpper()  //О
                    + otchestvo.Substring(1).ToLower() + " " //О.
                    + familiya.ToUpper());  //ФАМИЛИЯ
            }
            else  //иначе отчество не ввели
            {
                //выводим без отчетсва
                Console.WriteLine(imya[0].ToString().ToUpper()  //И
                    + imya.Substring(1).ToLower() + " " //мя
                    + familiya.ToUpper());  //ФАМИЛИЯ
            };
            //фам_и_о
            if (!string.IsNullOrEmpty(otchestvo))  //если отчество ввели
            {
                Console.WriteLine((familiya.Substring(0, 3) + "_"  //фам_
                    + imya.Substring(0, 1) + "_"  //и_
                    + otchestvo.Substring(0, 1)).ToLower());  //o
            }
            else  //иначе отчество не ввели
            {
                //выводим без отчетсва
                Console.WriteLine((familiya.Substring(0, 3) + "_"  //фам_
                    + imya.Substring(0, 1)));  //и_
            };
            //закрытие программы
            Console.ReadKey();
        }
    }
}
