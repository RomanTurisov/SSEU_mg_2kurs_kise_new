using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("������� ����� �������: ");
            int.TryParse(Console.ReadLine(), out n);
            int[] a = new int[n];
            //���� �������� �������
            //����� ������������� ��������
            int i = 0;
            int max = int.MinValue;
            int iMax = 0;
            while (i < n)
            {
                Console.Write("������� �[" + i + "]: ");
                if (int.TryParse(Console.ReadLine(), out a[i]))
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                        iMax = i;
                    };
                    i++;
                }
                else
                {
                    Console.WriteLine("������� ����� �����!");
                };
            };
            //����� ����������
            Console.Write("������������ ��������: " + max);
            //����� �� ���������
            Console.ReadKey();
        }
    }
}
