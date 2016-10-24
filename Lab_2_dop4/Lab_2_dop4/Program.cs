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
                    /*проверка равносторонний ли треугольник
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
                    */

                    // Является ли треугольник остроугольным, прямоугольным или тупоугольным
                     if (((a * a + b * b) > c * c) || ((a * a + c * c) > b * b) || ((b * b + c * c) > a * a))
                     {
                         Console.WriteLine("Треугольник остроугольный");
                     }
                     else
                     {
                         if (((a * a + b * b) == c * c) || ((a * a + c * c) == b * b) || ((b * b + c * c) > a * a))
                         {
                             Console.WriteLine("Треугольник прямоугольный");
                         }
                         else
                         {
                             Console.WriteLine("Треугольник тупоугольный");
                         };
                     };
                 }
                 else
                 {
                     Console.WriteLine("треугольник вырожденный ");
                 }
                 Console.ReadKey();
                 
                 /*Подсчет периметра и площади
                    double P, S;
                    P = (a + b + c) / 2;
                    S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));

                    if (P > 100 && S > 200)
                    {
                        Console.WriteLine("Треугольник большой");
                    }
                    else
                    {
                        if (P < 3 || S < 1)
                        {
                            Console.WriteLine("Треугольник маленький");
                        }
                    }*/
                }
            else
            {
                Console.WriteLine("Неверное значение!Нужно ввести целое число");
            }
                Console.ReadKey();
            }
        }
    }

