using System;
using System.Collections.Generic;
using System.Text;

namespace functionFotX
{
    class Program
    {
        static void Main(string[] args)
        {
            //���������� ����������
            double x;
            double.TryParse(Console.ReadLine(), out x);
            //���������� �������� ������� f(x)
            double func = - x / 23 * Math.Sqrt((Math.Pow(x, 2)) + 2 * x) + 1992;
            //����� ����������
            Console.WriteLine("�������� ������� f(x) = " + func);
            Console.ReadKey();
        }
    }
}
