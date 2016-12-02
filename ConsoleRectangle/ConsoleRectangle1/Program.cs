using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRectangle
{
    class Program
    {
        //ввод одной координаты, сообщение message выводится пользователю
        static double ReadCoord(string message)
        {
            double coord;
            Console.Write("Введите координату " + message);
            while (!double.TryParse(Console.ReadLine(), out coord))
            {
                Console.Write("Ошибка! Введите чисо: ");
            };
            return coord;
        }
        //прямоугольник
        class Rectangle
        {
            public double x1, y1; //верхний левый угол
            public double x2, y2; //правый нижний угол
            public Rectangle(double x1, double y1, double x2, double y2)
            {
                //начальные координаты
                this.x1 = x1; this.y1 = y1;
                this.x2 = x2; this.y2 = y2;
            }
            //ширина
            public double Width()
            {
                return Math.Abs(x2 - x1);
            }
            //высота
            public double Height()
            {
                return Math.Abs(y2 - y1);
            }
            //периметр
            public double P()
            {
                //2 * (ширина + высота)
                return 2 * (Width() + Height());
            }
            //площадь
            public double S()
            {
                //ширина * высота
                return Width() * Height();
            }
        }
        static void Main(string[] args)
        {
            Rectangle r; //один прямоугольник
            Console.WriteLine("Создание прямоугольника.");
            //создаем новый прямоугольник с введенными координатами
            r = new Rectangle(ReadCoord("x верхнего левого угла: "), 
                ReadCoord("y верхнего левого угла: "),
                ReadCoord("x нижнего правого угла: "), 
                ReadCoord("y нижнего правого угла: "));
            char key; //нажатая клавиша
            do
            {
                Console.Clear(); //очистка окна
                //вывод координат
                Console.WriteLine("Верхний левый угол: x = " + r.x1 + ", y = " + r.y1);
                Console.WriteLine("Нижний правый угол: x = " + r.x2 + ", y = " + r.y2);
                //вывод ширины и высоты
                Console.WriteLine("Ширина = " + r.Width());
                Console.WriteLine("Высота = " + r.Height());
                //вывод периметра
                Console.WriteLine("Периметр = " + r.P());
                //вывод площади
                Console.WriteLine("Площадь = " + r.S());
                //нажатие клавиши
                key = Console.ReadKey().KeyChar;
            }
            while (key != (char)27); //пока не нажат Esc
        }
    }
}
