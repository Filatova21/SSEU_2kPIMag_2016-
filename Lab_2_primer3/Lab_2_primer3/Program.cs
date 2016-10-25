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
            Console.WriteLine("В какой валюте указана сумма:1-доллары,2-евро,3-фунты,4-йены,5-рубли");
            int valuta;
            int.TryParse(Console.ReadLine(), out valuta);
            double itog;

            switch (valuta)
            {
                case 1://ввели доллары
                    Console.WriteLine("В какую валюту перевести:1-рубли,2-евро,3-фунты,4-йены");
                    int m;
                    int.TryParse(Console.ReadLine(), out m);
                    switch (m)
                    {
                        case 1:
                            itog = sum * 64;
                            Console.WriteLine("Итого " + itog + " рублей");
                            Console.ReadKey(); break;
                        case 2:
                            itog = sum * 0.9;
                            Console.WriteLine("Итого " + itog + " евро"); Console.ReadKey(); break;
                        case 3:
                            itog = sum * 0.82;
                            Console.WriteLine("Итого " + itog + " фунтов"); Console.ReadKey(); break;
                        case 4:
                            itog = sum * 104;
                            Console.WriteLine("Итого " + itog + " йен"); Console.ReadKey(); break;
                        default: Console.WriteLine("Вы ввели несоответствующее значение"); Console.ReadKey(); break;
                    }; break;

                case 2://ввели евро
                    Console.WriteLine("В какую валюту перевести:1-рубли,2-доллары,3-фунты,4-йены");
                    int s;
                    int.TryParse(Console.ReadLine(), out s);
                    switch (s)
                    {
                        case 1:
                            itog = sum * 76;
                            Console.WriteLine("Итого " + itog + " рублей"); Console.ReadKey(); break;
                        case 2:
                            itog = sum * 1.09;
                            Console.WriteLine("Итого " + itog + " долларов"); Console.ReadKey(); break;
                        case 3:
                            itog = sum * 0.89;
                            Console.WriteLine("Итого " + itog + " фунтов"); Console.ReadKey(); break;
                        case 4:
                            itog = sum * 113;
                            Console.WriteLine("Итого " + itog + " йен"); Console.ReadKey(); break;
                        default: Console.WriteLine("Вы ввели несоответствующее значение"); Console.ReadKey(); break;
                    }; break;

                case 3://ввели фунты
                    Console.WriteLine("В какую валюту перевести:1-рубли,2-доллары,3-евро,4-йены");
                    int x;
                    int.TryParse(Console.ReadLine(), out x);
                    switch (x)
                    {
                        case 1:
                            itog = sum * 76;
                            Console.WriteLine("Итого " + itog + " рублей"); Console.ReadKey(); break;
                        case 2:
                            itog = sum * 1.22;
                            Console.WriteLine("Итого " + itog + " долларов"); Console.ReadKey(); break;
                        case 3:
                            itog = sum * 1.12;
                            Console.WriteLine("Итого " + itog + " евро"); Console.ReadKey(); break;
                        case 4:
                            itog = sum * 127;
                            Console.WriteLine("Итого " + itog + " йен"); Console.ReadKey(); break;
                        default: Console.WriteLine("Вы ввели несоответствующее значение"); Console.ReadKey(); break;
                    }; break;

                case 4://ввели йены
                    Console.WriteLine("В какую валюту перевести:1-рубли,2-доллары,3-евро,4-фунты");
                    int k;
                    int.TryParse(Console.ReadLine(), out k);
                    switch (k)
                    {
                        case 1:
                            itog = sum * 0.6;
                            Console.WriteLine("Итого " + itog + " рублей"); Console.ReadKey(); break;
                        case 2:
                            itog = sum * 0.01;
                            Console.WriteLine("Итого " + itog + " долларов"); Console.ReadKey(); break;
                        case 3:
                            itog = sum * 0.01;
                            Console.WriteLine("Итого " + itog + " евро"); Console.ReadKey(); break;
                        case 4:
                            itog = sum * 0.01;
                            Console.WriteLine("Итого " + itog + " фунты"); Console.ReadKey(); break;
                        default: Console.WriteLine("Вы ввели несоответствующее значение"); Console.ReadKey(); break;
                    }; break;

                case 5://ввели рубли
                    Console.WriteLine("В какую валюту перевести:1-йен,2-доллары,3-евро,4-фунты");
                    int l;
                    int.TryParse(Console.ReadLine(), out l);
                    switch (l)
                    {
                        case 1:
                            itog = sum * 1.67;
                            Console.WriteLine("Итого " + itog + " йен"); Console.ReadKey(); break;
                        case 2:
                            itog = sum * 0.02;
                            Console.WriteLine("Итого " + itog + " долларов"); Console.ReadKey(); break;
                        case 3:
                            itog = sum * 0.01;
                            Console.WriteLine("Итого " + itog + " евро"); Console.ReadKey(); break;
                        case 4:
                            itog = sum * 0.01;
                            Console.WriteLine("Итого " + itog + " фунты"); Console.ReadKey(); break;
                        default: Console.WriteLine("Вы ввели несоответствующее значение"); Console.ReadKey(); break;
                    }; break;
            }
        }
    }
}
