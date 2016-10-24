using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод исходных значений
            int a, b;
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            //если больше А
            if (int.TryParse(Console.ReadLine(), out a))
            {
                int.TryParse(Console.ReadLine(), out b);
                //максимальное значение
                int max;
                if (a >= b)
                {
                    Max = a;
                }
                //иначе больше B
                else
                {
                    Max = b;
                };
                //Вывод результата
                Console.WriteLine("Максимальное = " + Max);
                //Завершение программы

            }
            else
            {
                Console.WriteLine("Неверное значение!Нужно ввести целое число");
            };

            //Проверка для B
            if (int.TryParse(Console.ReadLine(), out a))
            {
                if(int.TryParse(Console.ReadLine(), out b))
                {
                    //максимальное значение
                    int max;
                    if (a >= b)
                    {
                        Max = a;
                    }
                    //иначе больше B
                    else
                    {
                        Max = b;
                    };
                    //Вывод результата
                    Console.WriteLine("Максимальное = " + Max);
                }
                else
                {
                    Console.WriteLine("Неверное значение!Нужно ввести целое число");
                };
            }
            else
            {
                Console.WriteLine("Неверное значение!Нужно ввести целое число");
            };
            Console.ReadKey();
        }
    }
}
