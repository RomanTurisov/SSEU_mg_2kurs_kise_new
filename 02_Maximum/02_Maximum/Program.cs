using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            if (int.TryParse(Console.ReadLine(), out A)&& int.TryParse(Console.ReadLine(), out B) && int.TryParse(Console.ReadLine(), out C))
                {
                //������������ ��������
                int Max;
                //���� ������ A
                if (A >= B)
                {
                    Max = A;
                }
                //����� - ������ �
                else 
                {
                    Max = B;
                }
                //���� C ������ ������������� �� �, �, �� � - ������������
                if (C >= Max)
                {
                    Max = C;
                };
                    //����� ����������
                    Console.WriteLine("������������ = " + Max);
                }
                else
                {
                    Console.WriteLine("�������� ��������! ����� ������ ����� �����.");
                };
            //���������� ���������
            Console.ReadKey();
        }
    }
}
