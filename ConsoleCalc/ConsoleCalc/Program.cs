using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1, operand2; //операнды
            double result = 0; //результат вычисления
            string operation; //действие
            if (double.TryParse(Console.ReadLine(), out operand1) &&
                double.TryParse(Console.ReadLine(), out operand2))
            {
                //выбираем операцию
                operation = Console.ReadLine();
                switch (operation)
                {
                    case "+": result = operand1 + operand2; break;
                    case "-": result = operand1 - operand2; break;
                    case "*": result = operand1 * operand2; break;
                    case "/": result = operand1 / operand2; break;
                    case "sqrt": result = Math.Sqrt(operand1); break;
                    default: Console.WriteLine("Неверная операция!"); break;
                };
                //выводим результат
                Console.WriteLine(operand1 + " " + operation + " " + operand2 + " = " + result);
                Console.ReadKey();
            }
        }
    }
}
