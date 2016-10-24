using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_dop3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму покупки");
            int sum;
            int.TryParse(Console.ReadLine(), out sum);
            double itog;
            if (sum > 1000)
            {
                itog = sum - (sum * 15 / 1000);
                Console.WriteLine("Сумма с учетом скидки составляет " + itog);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Cкидка на данную сумму не предоставляется");
            };
            Console.ReadKey();
        }
    }
}
