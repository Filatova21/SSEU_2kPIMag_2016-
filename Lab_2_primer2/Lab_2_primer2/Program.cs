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
                if (a >= b)
                {
                    max = a;
                }
                else
                {
                    max = b;
                };
                if (c >= max)
                {
                    max = c;
                }
                Console.WriteLine("Максимальное " + max);
            }
            else
                {
                    Console.WriteLine("Неверное значение!Нужно ввести целое число");
                };
           
            Console.ReadKey();

        }
    }
}