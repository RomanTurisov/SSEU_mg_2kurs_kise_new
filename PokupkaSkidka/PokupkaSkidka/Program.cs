using System;
using System.Collections.Generic;
using System.Text;

namespace PokupkaSkidka
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum;
            double.TryParse(Console.ReadLine(), out sum);
            //���� ����� ������� ������ 1000�
            if (sum >= 1000)
            {
                double disc = sum - ( sum * 15 / 100 );
                //����� ����������
                Console.WriteLine("����� ������� � ������ ������ 15% = " + disc);
            }
            //� ��������������� ������ - ������ ���
            else
            {
                Console.WriteLine("����� ������� ������ 1000�. ������ �� ���������������!");
            };
            Console.ReadKey();
        }
    }
}
