using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            if (int.TryParse(Console.ReadLine(), out A))
            {
                if (int.TryParse(Console.ReadLine(), out B))
                {
                    //������������ ��������
                    int Max = (A >= B) ? A : B;
                    //����� ����������
                    Console.WriteLine("������������ = " + Max);
                }
                else
                {
                    Console.WriteLine("�������� ��������! ����� ������ ����� �����.");
                };
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
