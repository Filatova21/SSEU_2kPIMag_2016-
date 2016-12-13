using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRectangle
{
    class Rectangle//прямоугольник
    {
        public double x1, y1;//верхний левый угол
        public double x2, y2;//правый нижний
        public Rectangle(double x1, double y1, double x2, double y2)
        {
            //начальные координаты
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
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
            //2*(ширина+высота)
            return 2 * (Width() + Height());
        }
        //площадь
        public double S()
        {
            return Width() * Height();
        }

        //проверяем квадрат это или нет
        public bool IsSquare()
        {
            //ширина==высота?
            return Width() == Height();
        }

        //перемещение (метод ничего не возвращает)
        public void Move(double x, double y)
        {
            x1 += x; x2 += x;
            y1 += y; y2 += y;
        }
        //изменить ширину 
        public void SetWidth(double newWidth)
        {
            x2 = x1 + newWidth;
        }
        //изменить высоту 
        public void SetHeight(double newHeight)
        {
            y2 = y1 + newHeight;
        }
    }
    class Program
    {
        static double ReadCoord(string message)
        {
            double coord;
            Console.Write("Введите координату " + message);
            while (!double.TryParse(Console.ReadLine(), out coord))
            {
                Console.Write("Ошибка!Введите число");
            };
            return coord;
        }
        static void Main(string[] args)
        {
            //vменю
            Rectangle r;//один прямоугольник
            Console.WriteLine("Создание прямоуголника");
            //создаем новый прямоуг. с ввведенными коорд.
            r = new Rectangle(ReadCoord("x верхнего левого угла "),
                ReadCoord("y верхнего левого угла "),
                ReadCoord("x нижнего правого угла "),
                ReadCoord("y нижнего правого угла "));
            char key;//нажатая клавиша
            do
            {
                Console.Clear();
                Console.WriteLine("Верхний левый угол: x= " + r.x1 + ", y= " + r.y1);
                Console.WriteLine("Нижний правый угол: x= " + r.x2 + ", y= " + r.y2);
                Console.WriteLine("Ширина = " + r.Width());
                Console.WriteLine("Высота = " + r.Height());
                Console.WriteLine("Периметр = " + r.P());
                Console.WriteLine("Площадь = " + r.S());
                //меню
                Console.WriteLine("\t\t╔════════════════════════════╗");
                Console.WriteLine("\t\t║            МЕНЮ            ║");
                Console.WriteLine("\t\t║ a - является ли квадратом? ║");
                Console.WriteLine("\t\t║ b - переместить            ║");
                Console.WriteLine("\t\t║ c - изменить ширину        ║");
                Console.WriteLine("\t\t║ d - изменить высоту        ║");
                Console.WriteLine("\t\t║ ESC - выход                ║");
                Console.WriteLine("\t\t╚════════════════════════════╝");

                //нажатие клавиши
                key = Console.ReadKey().KeyChar;

                //проверка нажатой клавиши
                switch (key)
                {
                    case 'a':
                        Console.Clear();
                        if (r.IsSquare())
                            Console.WriteLine("Квадрат (" + r.Width() + " = " + r.Height() + ")");
                        else
                            Console.WriteLine("Не Квадрат (" + r.Width() + " != " + r.Height() + ")");
                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    case 'b': //перемещение
                        Console.Clear();
                        r.Move(ReadCoord("по x"), ReadCoord("по y"));
                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    case 'c': //изменить ширину
                        Console.Clear();
                        Console.WriteLine("Какую установить ширину?");
                        r.SetWidth(ReadCoord(""));
                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    case 'd': //изменить высоту
                        Console.Clear();
                        Console.WriteLine("Какую установить высоту?");
                        r.SetHeight(ReadCoord(""));
                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                };
            }
            while (key != (char)27);//пока не нажали ескейп

        }
    }
}
