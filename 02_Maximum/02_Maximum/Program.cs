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
                //���� A >= B
                if (A >= B)
                {
                    //� ���� A>= C
                    if (A >= C)
                    {
                        Max = A;
                    }
                    //����� - C >= A
                    else
                    {
                        Max = C;
                    }
                }
                //����� ������ B
                else
                {
                    //� ���� B >= C
                    if (B >= C)
                    {
                        //�� ������������ - B
                        Max = B;
                    }
                    //����� - C > B
                    else
                    {
                        //������������ C
                        Max = C;
                    }
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
