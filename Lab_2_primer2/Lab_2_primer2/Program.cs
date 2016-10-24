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
            int.TryParse(Console.ReadLine(), out a);
            int b;
            int.TryParse(Console.ReadLine(), out b);
            //максимальное значение
            int max = (a >= b) ? a : b;
            //вывод результата
            Console.WriteLine("Максимальное  " + max);
            Console.ReadKey();
        }
     }
  }
  
