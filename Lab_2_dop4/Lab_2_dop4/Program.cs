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
            float a, b, c;
            if (float.TryParse(Console.ReadLine(), out a) && float.TryParse(Console.ReadLine(), out b) && float.TryParse(Console.ReadLine(), out c))
            {
                if (((a + b) > c) && ((a + c) > b) && ((b + c) > a))
                {
                    //проверка равносторонний ли треугольник
                    if (a == b && a == c && b == c)
                    {
                        Console.WriteLine("Треугольник равносторонний");
                    }
                    else
                    {
                        // проверка равнобедренный ли треугольник
                    if (a == b || a == c || b == c)
                        {
                        Console.WriteLine("Треугольник равнобедренный ");
                        }
                    };
                }
            }
            else
            {
                Console.WriteLine("Неверное значение!Нужно ввести целое число");
            }
                Console.ReadKey();
            }
        }
    }

