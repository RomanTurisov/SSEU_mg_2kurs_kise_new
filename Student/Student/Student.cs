using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class Ozenki
    {
        byte[,] ozenki = new byte[8, 5]; //������

        public byte this[int semestr, int ekzamen]
        {
            get
            {
                //���� ����� �������� � �������� ����������
                if ((semestr >= 1 && semestr <= 8) && (ekzamen >= 1 && ekzamen <= 5))
                {
                    //�� ������� ������
                    return ozenki[semestr - 1, ekzamen - 1];
                };
                //����� - �������, ��� ������ �������� ���, ������� 0
                return 0;
            }
            set
            {
                //���� ����� �������� � �������� ����������
                if ((value >= 0 && value <= 5)
                    && (semestr >= 1 && semestr <= 8) && (ekzamen >= 1 && ekzamen <= 5))
                {
                    //�� ������� ������
                    ozenki[semestr - 1, ekzamen - 1] = value;
                };
                //����� - ������ �� ���������
            }
        }
    }

    class Student
    {
        string familiya = "";       //�������
        string imya = "";           //���
        string otchestvo = "";      //��������
        public string Nstud = "000000"; //� ����������
        int kurs = 1;                   //����
        public string gruppa = "";      //������
        public bool budget = true;      //������
        Ozenki ozenki = new Ozenki();   //������

        //�������� ��� ������� � �������
        public Ozenki Ozenki
        {
            get { return ozenki; }
        }

        //�������� ���
        public string FIO
        {
            get
            {
                //������� + ��� + ��������
                return familiya + " " + imya + " " + otchestvo;
            }
            set
            {
                //��������� ��������� ��� �� ��������
                string[] fio = value.Split(' ');
                if (fio.Length > 0)
                    familiya = fio[0];  //������ ����� - �������
                if (fio.Length > 1)
                    imya = fio[1];      //������ ����� - ���
                if (fio.Length > 2)
                    otchestvo = fio[2]; //������ ����� - ��������                  
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
                //���� ����� �������� �� 1 �� 4
                if (value >= 1 && value <= 4)
                {
                    //�� �������� ��� �������� � ����
                    kurs = value;
                };
            }
        }
        //���������� ����� � ���� ������
        public override string ToString()
        {
            //������ � ��������
            string strOzenki = "";
            //������� ���������
            for (int i = 0; i < KolvoSemestrov(); i++)
            {
                //������� ����� �������� � ������ �����
                strOzenki += (i + 1) + "�������: ";
                //������� ���������
                for (int j = 0; j < 5; j++)
                {
                    if (ozenki[i, j] == 1) //������
                        strOzenki += "������, "; //��������� ������ � ������
                    else if (ozenki[i, j] > 1) //���� ������
                        strOzenki += ozenki[i, j] + ", "; //��������� ������ � ������
                };
                //����� ������
            };
            return "���: " + FIO + "\r\n" +
                "� ����������: " + Nstud + "\r\n" +
                "����: " + kurs + "\r\n" +
                "������: " + gruppa + "\r\n" +
                strOzenki + "\r\n" + 
                "������� ����: " + SredniyBall();
        }
        //����������� �� ���������
        public Student() { }
        //�������� ������ �������� ����� ����������� ����� �� �������
        public Student(Student copyFrom)
        {
            //�������� �������� ���� �����
            FIO = copyFrom.FIO;
            Nstud = copyFrom.Nstud;
            kurs = copyFrom.kurs;
            gruppa = copyFrom.gruppa;
            ozenki = copyFrom.ozenki;
        }
        //��������� �� ��������� ����
        public void PerevestiNaSledKurs()
        {
            //��������� ���� �� 1
                kurs += 1;
        }
        //��������� ������� ����
        public double SredniyBall()
        {
            double sum = 0; //����� ������
            int n = 0; //���������� ��������� � ��������
            //��������� � ������������� ������ � �����
            for (int i = 0; i < KolvoSemestrov(); i++)
                for (int j = 0; j < 5; j++)
                {
                    if (ozenki[i, j] > 1)
                    {
                        sum += ozenki[i, j];
                        n++;
                    };
                };
            //���� ���� ��������
            if (n > 0)
                return sum / n; //������� ���� = ����� / ����������
            else
                return 0; //������� ���� = 0
        }

        //���������� ���������
        protected int KolvoSemestrov()
        {
            //� ������ ����� 2 ��������
            return 2 * kurs;
        }

        //���������� ��������� ��������� �� ��������� �������
        protected int KolvoNesdach(int semestr)
        {
            int k = 0; //�� ��������� 0
            //���������� ��� �������� �� �������
            for (int i = 0; i < 5; i++)
            {
                //���� ������ ��� ����
                if ((ozenki[semestr, i] == 1) || (ozenki[semestr, i] == 2))
                {
                    //�� ������� ��� ���������
                    k += 1;
                }
            }
            //���������� ���������
            return k;
        }
    }

    class StudentBudg : Student
    {
        public StudentBudg(Student copyForm) : base(copyForm) { }   //�����������
        const decimal stipSum = 1500m; //����� ������� ���������
        const decimal stipPovyshSum = 1800m; //����� ���������� ���������
        //���������� ��������� �� ��������� �������
        public decimal Stipendia(int semestr)
        {
            //���� ������� �� ������� �� ���������� �������
            if ((semestr >= 0) && (semestr <= KolvoSemestrov()))
            {
                    bool stip = true; //���� ���������
                    bool stipPovysh = true; //���� ���������� ���������
                    int n = 0; //���������� ���������
                    for (int i = 0; i < 5; i++)
                    {
                        if (Ozenki[semestr, i] > 0) //���� ������� ���
                        {
                            n++; //��������� ���������� ���������
                            stip &= (Ozenki[semestr, i] > 3); //������� ��������� - ������ ���� 3
                            stipPovysh &= (Ozenki[semestr, i] == 5); //���������� - ������ 5
                        };
                    };
                    if (n == 0) //�� ���� ���������
                        return 0; //��� ��� ���������
                    if (stipPovysh) //���� ���������� ���������
                        return stipPovyshSum;
                    else if (stip) //���� ������� ���������
                        return stipSum;
                    else
                        return 0;
            };
            return 0; //������������ ������� - ��� ���������
        }
        //����� ���������� � ��������-����������
        public override string ToString()
        {
            //��������� ������ � ��������� �� ������ �������
            string stipendia = "���������:\r\n";
            for (int i = 0; i < KolvoSemestrov(); i++)
                stipendia += i + "�������: " + Stipendia(i) + " ���.\r\n";
            //�������� ��������� ��
            return base.ToString() + "\r\n" //������ ������-������ (Student),
            + "�������� �� ��������� ������\r\n" //������ � ��������� ��������
            + stipendia; //� ���������
        }
    }

    class StudentPlat : Student
    {
        public decimal stoimostObucheniya; //��������� �������� �� �������
        public decimal oplacheno; //������� ������� ������� � �����

        //�������� ��������
        public void OplataObuchenie(decimal sum)
        {
            //���� ��������� �� ��������� �����
            oplacheno += sum;
        }

        //������������� �� �������� (��� ���������, ���� �������������)
        public decimal Dolg()
        {
            //���� = ��������� �������� �� ������� * ���-�� ��������� - ���������� �����
            return stoimostObucheniya * KolvoSemestrov() - oplacheno;
        }
        //�����������
        public StudentPlat(Student copyForm) : base(copyForm)
        {
            //���� ������� copyForm �������� ���������
            if (copyForm is StudentPlat)
            {
                //�� ����������� ��������� �������� � ����� �����,
                //������������ copyForm ��� ��������
                stoimostObucheniya = (copyForm as StudentPlat).stoimostObucheniya;
                oplacheno = (copyForm as StudentPlat).oplacheno;
            };
        }

        //����� ���������� � ��������-��������
        public override string ToString()
        {
            //�������� ��������� ��
            return base.ToString() + "\r\n" //������ ������-������ (Student),
            + "�������� �� ������� ������\r\n" //������ � ������� ��������,
            + "��������� ��������: " + stoimostObucheniya + "���.\r\n" //��������� ��������
            + "�������������: " + Dolg() + " ���."; //� ���������
        }
    }
}
