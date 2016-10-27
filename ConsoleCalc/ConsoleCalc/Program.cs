using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1, operand2; //��������
            double result = 0; //��������� ����������
            string operation; //��������
            if (double.TryParse(Console.ReadLine(), out operand1) &&
                double.TryParse(Console.ReadLine(), out operand2))
            {
                //�������� ��������
                operation = Console.ReadLine();
                switch (operation)
                {
                    //�������� � ����� ����������
                    case "+":                        
                    case "-":                        
                    case "*":
                    case "/":
                        //���������� ������ �������
                        if (double.TryParse(Console.ReadLine(), out operand2))
                        {
                            //����� ������ ��������
                            switch (operation)
                            {
                                case "+": result = operand1 + operand2; break;
                                case "-": result = operand1 - operand2; break;
                                case "*": result = operand1 * operand2; break;
                                case "/": result = operand1 / operand2; break;
                            };
                        }
                        else
                        {
                            Console.WriteLine("������� ������ ���� ������!");
                        };
                    //�������� � ����� ���������
                    case "sqrt": result = Math.Sqrt(operand1); break;
                    //������������ ��������
                    default: Console.WriteLine("�������� ��������!"); Console.ReadKey(); return;
                };
                //������� ���������
                Console.WriteLine(operand1 + " " + operation + " " + operand2 + " = " + result);
                Console.ReadKey();
            }
        }
    }
}
