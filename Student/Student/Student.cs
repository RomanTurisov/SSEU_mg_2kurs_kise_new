using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class Ozenki
    {
        byte[,] ozenki = new byte[8, 5]; //Оценки

        public byte this[int semestr, int ekzamen]
        {
            get
            {
                //если номер семестра и экзамена корректный
                if ((semestr >= 1 && semestr <= 8) && (ekzamen >= 1 && ekzamen <= 5))
                {
                    //то вернуть оценку
                    return ozenki[semestr - 1, ekzamen - 1];
                };
                //иначе - считаем, что такого экзамена нет, вернуть 0
                return 0;
            }
            set
            {
                //если номер семестра и экзамена корректный
                if ((value >= 0 && value <= 5)
                    && (semestr >= 1 && semestr <= 8) && (ekzamen >= 1 && ekzamen <= 5))
                {
                    //то вернуть оценку
                    ozenki[semestr - 1, ekzamen - 1] = value;
                };
                //иначе - ничего не сохраняем
            }
        }
    }

    class Student
    {
        string familiya = "";       //фамилия
        string imya = "";           //имя
        string otchestvo = "";      //отчество
        public string Nstud = "000000"; //№ студБилета
        int kurs = 1;                   //Курс
        public string gruppa = "";      //Группа
        public bool budget = true;      //Бюджет
        Ozenki ozenki = new Ozenki();   //Оценки

        //свойство для доступа к оценкам
        public Ozenki Ozenki
        {
            get { return ozenki; }
        }

        //свойство ФИО
        public string FIO
        {
            get
            {
                //фамилия + имя + отчество
                return familiya + " " + imya + " " + otchestvo;
            }
            set
            {
                //разделить введенное ФИО по пробелам
                string[] fio = value.Split(' ');
                if (fio.Length > 0)
                    familiya = fio[0];  //первое слово - фамилия
                if (fio.Length > 1)
                    imya = fio[1];      //второе слово - имя
                if (fio.Length > 2)
                    otchestvo = fio[2]; //третье слово - отчество                  
            }
        }
        public int Kurs
        {
            get
            {
                return kurs;
            }

            set
            {
                //если новое значение от 1 до 4
                if (value >= 1 && value <= 4)
                {
                    //то записать это значение в поле
                    kurs = value;
                };
            }
        }
        //содержимое полей в виде текста
        public override string ToString()
        {
            //строка с оценками
            string strOzenki = "";
            //перебор семестров
            for (int i = 0; i < KolvoSemestrov(); i++)
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
            };
            return "ФИО: " + FIO + "\r\n" +
                "№ студбилета: " + Nstud + "\r\n" +
                "Курс: " + kurs + "\r\n" +
                "Группа: " + gruppa + "\r\n" +
                strOzenki + "\r\n" + 
                "Средний балл: " + SredniyBall();
        }
        //конструктор по умолчанию
        public Student() { }
        //создание нового студента путем копирования полей из другого
        public Student(Student copyFrom)
        {
            //копируем значения всех полей
            FIO = copyFrom.FIO;
            Nstud = copyFrom.Nstud;
            kurs = copyFrom.kurs;
            gruppa = copyFrom.gruppa;
            ozenki = copyFrom.ozenki;
        }
        //перевести на следующий курс
        public void PerevestiNaSledKurs()
        {
            //увеличить курс на 1
                kurs += 1;
        }
        //вычислить средний балл
        public double SredniyBall()
        {
            double sum = 0; //сумма баллов
            int n = 0; //количество экзаменов с оценками
            //суммируем и пересчитываем оценки в цикле
            for (int i = 0; i < KolvoSemestrov(); i++)
                for (int j = 0; j < 5; j++)
                {
                    if (ozenki[i, j] > 1)
                    {
                        sum += ozenki[i, j];
                        n++;
                    };
                };
            //если были экзамены
            if (n > 0)
                return sum / n; //средний балл = сумма / количество
            else
                return 0; //средний балл = 0
        }

        //количество семестров
        protected int KolvoSemestrov()
        {
            //в каждом курсе 2 семестра
            return 2 * kurs;
        }

        //количество несданных экзаменов за указанный семестр
        protected int KolvoNesdach(int semestr)
        {
            int k = 0; //по умолчанию 0
            //перебираем все экзамены за семестр
            for (int i = 0; i < 5; i++)
            {
                //если неявка или неуд
                if ((ozenki[semestr, i] == 1) || (ozenki[semestr, i] == 2))
                {
                    //то считаем как несданный
                    k += 1;
                }
            }
            //возвращаем результат
            return k;
        }
    }

    class StudentBudg : Student
    {
        public StudentBudg(Student copyForm) : base(copyForm) { }   //скопировать
        const decimal stipSum = 1500m; //сумма обычной стипендии
        const decimal stipPovyshSum = 1800m; //сумма повышенной стипендии
        //определить стипендию за указанный семестр
        public decimal Stipendia(int semestr)
        {
            //если семестр не выходит за допустимые границы
            if ((semestr >= 0) && (semestr <= KolvoSemestrov()))
            {
                    bool stip = true; //есть стипендия
                    bool stipPovysh = true; //есть повышенная стипендия
                    int n = 0; //количество экзаменов
                    for (int i = 0; i < 5; i++)
                    {
                        if (Ozenki[semestr, i] > 0) //если экзамен был
                        {
                            n++; //увеличить количество экзаменов
                            stip &= (Ozenki[semestr, i] > 3); //обычная стипендия - оценка выше 3
                            stipPovysh &= (Ozenki[semestr, i] == 5); //повышенная - оценка 5
                        };
                    };
                    if (n == 0) //не было экзаменов
                        return 0; //еще нет стипендии
                    if (stipPovysh) //есть повышенная стипендия
                        return stipPovyshSum;
                    else if (stip) //есть обычная стипендия
                        return stipSum;
                    else
                        return 0;
            };
            return 0; //недопустимый семестр - нет стипендии
        }
        //вывод информации о студенте-бюджетнике
        public override string ToString()
        {
            //формируем записи о стипендии за каждый семестр
            string stipendia = "Стипендия:\r\n";
            for (int i = 0; i < KolvoSemestrov(); i++)
                stipendia += i + "семестр: " + Stipendia(i) + " руб.\r\n";
            //собираем результат из
            return base.ToString() + "\r\n" //метода класса-предка (Student),
            + "Обучение на бюджетной основе\r\n" //записи о бюджетном обучении
            + stipendia; //и стипендии
        }
    }

    class StudentPlat : Student
    {
        public decimal stoimostObucheniya; //стоимость обучения за семестр
        public decimal oplacheno; //сколько оплатил студент в сумме

        //оплатить обучение
        public void OplataObuchenie(decimal sum)
        {
            //долг снижается на указанную сумму
            oplacheno += sum;
        }

        //задолженность за обучение (или переплата, если отрицательное)
        public decimal Dolg()
        {
            //долг = стоимость обучения за семестр * кол-во семестров - оплаченная сумма
            return stoimostObucheniya * KolvoSemestrov() - oplacheno;
        }
        //скопировать
        public StudentPlat(Student copyForm) : base(copyForm)
        {
            //если студент copyForm является платником
            if (copyForm is StudentPlat)
            {
                //то скопировать стоимость обучения и сумму долга,
                //рассматривая copyForm как платника
                stoimostObucheniya = (copyForm as StudentPlat).stoimostObucheniya;
                oplacheno = (copyForm as StudentPlat).oplacheno;
            };
        }

        //вывод информации о студенте-платнике
        public override string ToString()
        {
            //собираем результат из
            return base.ToString() + "\r\n" //метода класса-предка (Student),
            + "Обучение на платной основе\r\n" //записи о платном обучении,
            + "Стоимость обучения: " + stoimostObucheniya + "руб.\r\n" //стоимости обучения
            + "Задолженность: " + Dolg() + " руб."; //и стипендии
        }
    }
}
