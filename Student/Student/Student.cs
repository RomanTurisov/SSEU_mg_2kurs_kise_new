using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class Student
    {
        public string FIO = "";                 //ФИО
        public string Nstud = "000000";         //№ студБилета
        public int kurs = 1;                    //Курс
        public string gruppa = "";              //Группа
        public bool budget = true;              //Бюджет
        public byte[,] ozenki = new byte[8, 5]; //Оценки
        //содержимое полей в виде текста
        public string ToString()
        {
            //строка с оценками
            string strOzenki = "";
            //перебор семестров
            for (int i = 0; i < 2 * kurs; i++)
            {
                //выводим номер семестра в начале стоки
                strOzenki += (i + 1) + "семестр: ";
                //перебор экзаменов
                for (int j = 0; j < 5; j++)
                {
                    if (ozenki[i, j] == 1) //неявка
                        strOzenki += "неявка, "; //добавляем оценку к строке
                    else if (ozenki[i, j] > 1) //есть оценка
                        strOzenki += ozenki[i, j] + ", "; //добавляем оценку к строке
                };
                //конец строки
                strOzenki += "\r\n";
            };
            return "ФИО: " + FIO + "\r\n" +
                "№ студбилета: " + Nstud + "\r\n" +
                "Курс: " + kurs + "\r\n" +
                "Группа: " + gruppa + "\r\n" +
                (budget ? "На бюджетной основе" : "На коммерческой основе") + "\r\n" +
                strOzenki;
        }

    }
}
