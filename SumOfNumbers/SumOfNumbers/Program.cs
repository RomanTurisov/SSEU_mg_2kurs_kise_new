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
                int i = 0; //������� ���������� ���������
                //N ���
                while(i < N)
                {
                    Console.Write("������� �����: ");
                    //���� ������� ���������� �����
                    if (int.TryParse(Console.ReadLine(), out x))
                    {
                        Sum += x; //�������� � �����
                        /*DEBUG INFO
                        Console.WriteLine("{" + Sum + "}");
                        //*/
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("�������� ��������! ������� ����� �����!");
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
