using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N; //���������� �����
            int F = 1;
            Console.WriteLine("������� ����� ��� ���������� ����������: ");
            N = int.Parse(Console.ReadLine());
            for (int c = N; c > 1; c--)
                F = F * c;
            Console.WriteLine("��������� " + N + "! = " + F);
            //���������� ���������
            Console.ReadLine();
        }
    }
}
