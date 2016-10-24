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
            int a;
            int b;
            if (int.TryParse(Console.ReadLine(), out a))
            {
                if (int.TryParse(Console.ReadLine(), out b))
                {
                    //максимальное значение
                    int max;
                    if (a >= b)
                    {
                        max = a;
                    }
                    //иначе больше B
                    else
                    {
                        max = b;
                    };
                    //Вывод результата
                    Console.WriteLine("Максимальное = " + max);
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