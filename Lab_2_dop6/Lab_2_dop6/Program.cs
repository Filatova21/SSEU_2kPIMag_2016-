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
            double procenty=0;
            double vel_ek_vyplat = 0;
            switch (metod)
            {
                case 1:
                    summa_itog = sum * (1 + srok * stavka*0.01);
                    procenty = summa_itog - sum;
                    vel_ek_vyplat = (summa_itog / srok) / 12;
                    break;
                case 2:
                    summa_itog = sum * Math.Pow((1 +  stavka),3);
                    procenty = summa_itog - sum;
                    vel_ek_vyplat = procenty / srok / 12;
                    break;
            }
            Console.WriteLine("Итого выплат за " +srok+" года :"+ sum);
            Console.WriteLine("Из них начислено процентов: " + procenty);
            Console.WriteLine("Величина эквивалентных выплат:  " + vel_ek_vyplat);
            Console.ReadKey();
        }
    }
}
