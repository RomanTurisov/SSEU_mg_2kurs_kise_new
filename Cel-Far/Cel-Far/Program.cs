using System;
using System.Collections.Generic;
using System.Text;

namespace Cel_Far
{
    class Program
    {
        static void Main(string[] args)
        {
            //���������� ����������
            double cel;
            double.TryParse(Console.ReadLine(), out cel);
            //�������������� �������� ������� � ������� ����������
            double celfar = (cel * 1.8) + 32;
            //����� ����������
            Console.WriteLine(celfar + " �������� ����������");
            Console.ReadKey();
        }
    }
}
