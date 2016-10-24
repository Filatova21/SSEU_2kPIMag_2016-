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
            int a, b, c;
            int max;
            if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b) && int.TryParse(Console.ReadLine(), out c))
            {
                //если а больше остальных
                if ((a >= b) && (a >= c))
                {
                    max = a;
                }
                //иначе,если b больше остальных
                else if ((b >= a) && (b >= c))
                {
                    max = b;
                }
                else
                {
                    max = c;
                };
                //Вывод результата
                Console.WriteLine("Максимальное = " + max);
            }
            else
                {
                    Console.WriteLine("Неверное значение!Нужно ввести целое число");
                };
           
            Console.ReadKey();

        }
    }
}