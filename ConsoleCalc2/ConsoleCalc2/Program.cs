using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalc
{
    class Program
    {
        //ввод операнда с консоли с проверкой значения
        static double ReadOperand()
        {
            double operand = 0; //значение операнда
            Console.Write("Введите число: ");
            //повторять ввод, пока не будет введено корректное значение
            while (!double.TryParse(Console.ReadLine(), out operand))
            {
                Console.Write("Неверное значение! Введите число: ");
            };
            //вернуть значение
            return operand;
        }
        static void Main(string[] args)
        {
            //первый операнд
            double operand1 = ReadOperand();
            //второй операнд
            double operand2;
            //действие
            string operation; 
                do
            {
                //выбираем операцию
                operation = Console.ReadLine();
                operation = operation.ToLower();
                switch (operation)
                {
                    //операция с двумя операндами
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                    //считывааем второй операнд
                    operand2 = ReadOperand();
                    //какая именно операция
                    switch (operation)
                    {
                        case "+": operand1 = operand1 + operand2; break;
                        case "-": operand1 = operand1 - operand2; break;
                        case "*": operand1 = operand1 * operand2; break;
                        case "/": operand1 = operand1 / operand2; break;
                    };
                    break;
                    //операции с одним операндом
                    case "sqrt": operand1 = Math.Sqrt(operand1); break;
                    //выход из программы
                    case "quit": case "exit": return;
                        //недопустимые операции
                    default: Console.WriteLine("Неверная операция!"); break;
                };
                    //выводим результат
                    Console.WriteLine(" = " + operand1);
                }
                //пока не будет введена команда выхода
                while (!((operation == "quit") || (operation == "exit"))); 
        }
    }
}
