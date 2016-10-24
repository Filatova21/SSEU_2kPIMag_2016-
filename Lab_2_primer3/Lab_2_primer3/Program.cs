using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Months
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму для перевода");
            int sum;
            int.TryParse(Console.ReadLine(), out sum);
            //Console.WriteLine("В какой валюте указана сумма");

            Console.WriteLine("В какую валюту перевести:1-доллары,2-евро,3-фунты,4-йены");
            int m;
            double itog;
            if(int.TryParse(Console.ReadLine(), out m))
            {
                switch (m)
                {
                    case 1://доллары
                        itog = sum / 64;
                        Console.WriteLine("Итого "+itog+" долларов");break;

                    case 2: //евро
                        itog = sum / 78;
                        Console.WriteLine("Итого " + itog + " евро"); break;

                    case 3: //фунты
                        itog = sum /76;
                        Console.WriteLine("Итого " + itog + " фунтов"); break;

                    case 4: //йены
                        itog = sum*6/10;
                        Console.WriteLine("Итого " + itog + " йен"); break;
                    default:Console.WriteLine("Вы ввели несоответствующее значение");break;
                };
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Неверное значение,введите целое число");
            }
        }
    }
}
