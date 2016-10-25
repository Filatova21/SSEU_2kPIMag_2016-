using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_dop6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму кредита");
            int sum;
            int.TryParse(Console.ReadLine(), out sum);
            Console.WriteLine("Введите срок кредитования в годах");
            int srok;
            int.TryParse(Console.ReadLine(), out srok);
            Console.WriteLine("Введите годовую процентную ставку");
            int stavka;
            int.TryParse(Console.ReadLine(), out stavka);
            Console.WriteLine("Введите частоту выплат");
            int vyplaty;
            int.TryParse(Console.ReadLine(), out vyplaty);
            Console.WriteLine("выберите метод начисления: 1-простой 2-сложный");
            int metod;
            int.TryParse(Console.ReadLine(), out metod);
            double summa_itog = 0;
            double procenty = 0;
            double vel_ek_vyplat = 0;
            switch (metod)
                {
                    case 1:
                        summa_itog = sum * (1 + srok * stavka * 0.01);
                        procenty = summa_itog - sum;
                        vel_ek_vyplat = (summa_itog / srok) / 12;
                        break;
                    case 2:
                        summa_itog = sum * Math.Pow((1 + stavka * 0.01), 3);
                        procenty = summa_itog - sum;
                        vel_ek_vyplat = procenty / srok / 12;
                        break;
                };
            Console.WriteLine("1 вариант: Итого выплат за " + srok + " года :" + summa_itog);
            Console.WriteLine("Из них начислено процентов: " + procenty);
            Console.WriteLine("Величина эквивалентных выплат:  " + vel_ek_vyplat);

            Console.WriteLine("Хотите ввести еще один вариант кредитования для сравнения? 1-да  2-нет");
            int a;
            int.TryParse(Console.ReadLine(), out a);
            if (a == 1)
            {
                //вводим данные для 2 варианта
                Console.WriteLine("Введите срок кредитования в годах");
                int srok_2;
                int.TryParse(Console.ReadLine(), out srok_2);
                Console.WriteLine("Введите годовую процентную ставку");
                int stavka_2;
                int.TryParse(Console.ReadLine(), out stavka_2);
                Console.WriteLine("Введите частоту выплат");
                int vyplaty_2;
                int.TryParse(Console.ReadLine(), out vyplaty_2);
                Console.WriteLine("выберите метод начисления: 1-простой 2-сложный");
                int metod_2;
                int.TryParse(Console.ReadLine(), out metod_2);
                double summa_itog_2 = 0;
                double procenty_2 = 0;
                double vel_ek_vyplat_2 = 0;
                switch (metod)
                {
                    case 1:
                        summa_itog_2 = sum * (1 + srok_2 * stavka_2 * 0.01);
                        procenty_2 = summa_itog_2 - sum;
                        vel_ek_vyplat_2 = (summa_itog_2 / srok_2) / 12;
                        break;
                    case 2:
                        summa_itog_2 = sum * Math.Pow((1 + stavka_2 * 0.01), 3);
                        procenty_2 = summa_itog_2 - sum;
                        vel_ek_vyplat_2 = procenty_2 / srok_2 / 12;
                        break;
                };
                Console.WriteLine("2 вариант: Итого выплат за " + srok_2 + " года :" + summa_itog_2);
                Console.WriteLine("Из них начислено процентов: " + procenty_2);
                Console.WriteLine("Величина эквивалентных выплат:  " + vel_ek_vyplat_2);
                if(summa_itog_2< summa_itog)
                {
                    Console.WriteLine("Выгоднее брать кредит под вариантом 2 ");
                }
                else
                {
                    Console.WriteLine("Выгоднее брать кредит под вариантом 1 ");
                };
            }
            else
            {
                return;
            };

            Console.ReadKey();
        }
    }
}
