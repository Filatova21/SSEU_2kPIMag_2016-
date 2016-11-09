using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_dop_5
{
    class Program
    {
        static double ReadOperand()
        {
            double operand = 0;//значение операнда
            Console.Write("Введите координату: ");
            //повторять ввод,пока не будет введено корректное значение
            while (!double.TryParse(Console.ReadLine(), out operand))
            {
                Console.Write("Неверное значение! Введите число: ");
            };
            //вернуть значение
            return operand;
        }

        static void Main(string[] args)
        {
            Console.Write("Сколько выстрелов будете совершать? ");
            int kol_vystrel;
            double itog=0;
            int.TryParse(Console.ReadLine(), out kol_vystrel);
            double[] a = new double[kol_vystrel];//массив координат x
            double[] b = new double[kol_vystrel];//массив координат y
            double[] R = new double[kol_vystrel];//массив координат радиусов
            double[] ochki = new double[kol_vystrel];//массив набранных очков
            
            for (int i=0;i< kol_vystrel; ++i)
            {
                double buf = 0;
                double x;
                x = ReadOperand();
                double y;
                y = ReadOperand();
                a[i] = x;
                b[i] = y;
                if (x*x+y*y<=25)//круг 100
                {
                    buf = 100;
                    R[i] = x * x + y * y;
                }
                if((x * x + y * y > 25)&& (x * x + y * y <= 100))//круг 50
                {
                    buf = 50;
                    R[i] = x * x + y * y;
                }
                if((x * x + y * y > 100) && (x * x + y * y <= 225))//круг 20
                {
                    buf = 20;
                    R[i] = x * x + y * y;
                }
                if ((x * x + y * y > 225) && (x * x + y * y <= 625))//круг 10
                {
                    buf = 10;
                    R[i] = x * x + y * y;
                }
                if ((x * x + y * y) == 900)//радиус равен 30
                {
                    buf = 5;
                    R[i] = x * x + y * y;
                }
                if (x * x + y * y > 625)//за мишенью
                {
                    Console.WriteLine("Вы не попали в мишень" + "\n");
                    buf = 0;
                    R[i] = x * x + y * y;
                }
                Console.WriteLine("Очки за выстрел: " + buf + "\n");
                ochki[i] = buf;
                itog = itog + buf;
            }
            double min = R[2];
            //Ищем наиболее близкую к центру точку
            for (int i = 0; i < R.Length; ++i)
            {
                if (R[i] < min)
                {
                    min = R[i];
                }
            }
            Console.WriteLine("Минимальный радиус: " + min + "\n");
            for (int i=0; i< kol_vystrel; ++i)
            {
                if (min == a[i] * a[i] + b[i] * b[i])
                {
                    Console.WriteLine("Наиболее близкий к центру выстрел с координатами: " + a[i]+";" +b[i]+ "\n");
                }
            }
            //выводим таблицу
            for (int i = 0; i < kol_vystrel; ++i)
            {
                Console.WriteLine("Выстрел №"+(i+1)+" с координатами: " +"("+ a[i] + " ; " + b[i] + ")" + "   Очки за выстрел: " + ochki[i]+"\n");
            }
            Console.WriteLine("Всего набрано: " + itog + " очков");
            Console.ReadKey();
        }
    }
}
