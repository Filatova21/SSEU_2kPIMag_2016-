using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_dop4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника");
            double a, b, c;
            if (double.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out b) && double.TryParse(Console.ReadLine(), out c))
            {
                if (((a + b) > c) && ((a + c) > b) && ((b + c) > a))//если треугольник невырожденный
                {
                    //Подсчет периметра и площади
                    double P, S;
                    P = (a + b + c) / 2;
                    S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));

                    if (P > 100 && S > 200)
                    {
                        Console.WriteLine("Треугольник большой");
                    }
                    else if (P < 3 || S < 1)
                        {
                            Console.WriteLine("Треугольник маленький");
                        };
                    }
               
            }
            else
            {
                Console.WriteLine("Неверное значение!Нужно ввести целое число");
            };
                Console.ReadKey();
            }
        }
    }


    


