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
            int x; //���� �����
            Console.Write("������� ���������� ����� ��� ������������: ");
            if (int.TryParse(Console.ReadLine(), out N))
            {
                int Sum = 0; //����� �����
                //N ���
                for (int i = 0; i < N; i++)
                {
                    Console.Write("������� �����: ");
                    //���� ������� ���������� �����
                    if (int.TryParse(Console.ReadLine(), out x))
                    {
                        Sum += x; //�������� � �����
                        /*DEBUG INFO
                        Console.WriteLine("{" + Sum + "}");
                        //*/
                    }
                    else
                    {
                        Console.WriteLine("�������� ��������! ������� ����� �����!");
                        i--;
                    };
                };
                //����� ����������
                Console.WriteLine("�����: " + Sum);
            };
            //���������� ���������
            Console.ReadKey();
        }
    }
}
