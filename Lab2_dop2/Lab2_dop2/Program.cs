using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_dop2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, x;
            Console.WriteLine("Введите x");
            int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Введите a");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введите b");
            int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Введите c");
            int.TryParse(Console.ReadLine(), out c);
            double f;
            f = -x / a * (Math.Sqrt(Math.Pow(x, 2) + b * x)) + c;
            Console.WriteLine("f(x)" + "=" + f);
            Console.ReadKey();
        }
    }
}
