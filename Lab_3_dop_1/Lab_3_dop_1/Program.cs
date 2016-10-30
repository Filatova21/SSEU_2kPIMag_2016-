using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_dop_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Факториал какого числа необходимо посчитать?");
            int N;
            if (int.TryParse(Console.ReadLine(), out N))
            {
                int Proizv = 0;//факториал
                int result = 1;
                for (int i=1; i <= N;i++)
                {
                    result = result*i;
                }
                //вывод результата
                Console.WriteLine("Факториал числа " +N+" = "+ result);
            };

            //завершение программы
            Console.ReadKey();
        }
    }
}
      
