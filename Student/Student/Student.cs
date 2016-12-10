using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class Student
    {
        public string FIO = "";                 //���
        public string Nstud = "000000";         //� ����������
        public int kurs = 1;                    //����
        public string gruppa = "";              //������
        public bool budget = true;              //������
        public byte[,] ozenki = new byte[8, 5]; //������
        //���������� ����� � ���� ������
        public override string ToString()
        {
            //������ � ��������
            string strOzenki = "";
            //������� ���������
            for (int i = 0; i < 2 * kurs; i++)
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
            //���� ���� �� ������������, �� ��������� �� 1
            if (kurs < 4)
                kurs += 1;
        }
        //��������� ������� ����
        public double SredniyBall()
        {
            double sum = 0; //����� ������
            int n = 0; //���������� ��������� � ��������
            //��������� � ������������� ������ � �����
            for (int i = 0; i < 2 * kurs; i++)
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
            if ((semestr >= 0) && (semestr <= 2 * kurs))
            {
                    bool stip = true; //���� ���������
                    bool stipPovysh = true; //���� ���������� ���������
                    int n = 0; //���������� ���������
                    for (int i = 0; i < 5; i++)
                    {
                        if (ozenki[semestr, i] > 0) //���� ������� ���
                        {
                            n++; //��������� ���������� ���������
                            stip &= (ozenki[semestr, i] > 3); //������� ��������� - ������ ���� 3
                            stipPovysh &= (ozenki[semestr, i] == 5); //���������� - ������ 5
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
            for (int i = 0; i < 2 * kurs; i++)
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
            return stoimostObucheniya * kurs * 2 - oplacheno;
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
