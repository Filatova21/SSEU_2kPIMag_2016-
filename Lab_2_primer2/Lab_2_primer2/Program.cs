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
            //int max;
            if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b) && int.TryParse(Console.ReadLine(), out c))
            {
                int max = ((max=(a>=b)?a:b)>=c)?max:c;
                Console.WriteLine("Максимальное  " + max);
                Console.ReadKey();
            }
            else
                {
                    Console.WriteLine("Неверное значение!Нужно ввести целое число");
                };
           
            Console.ReadKey();

        }
    }
}