using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //���� �������� ��������
            int A, B;
            int.TryParse(Console.ReadLine(), out A);
            int.TryParse(Console.ReadLine(), out B);
            //������������ ��������
            int Max;
            //���� ������ �
            if (A >= B)
            {
                Max = A;
            }
            //����� - ������ �
            else
            {
                Max = B;
            };
            //����� ����������
            Console.WriteLine("������������ = " + Max);
            //���������� ���������
            Console.ReadKey();
        }
    }
}
