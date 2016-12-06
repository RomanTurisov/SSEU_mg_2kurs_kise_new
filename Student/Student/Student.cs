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
    }
}
