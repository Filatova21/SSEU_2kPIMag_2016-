using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_primer1_dop1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a; //переменная,которую вводит пользователь 
            int razn = 32;// разница Цельсия и Фаренгейта
            int.TryParse(Console.ReadLine(), out a);
            int itog;//переменная,выводящая итоговое значение градусов по Фаренгейту
            itog = a*1.8 + razn;
            Console.WriteLine('Значение по Фаренгейту'+'='+itog);
            Console.ReadKey();

        }
    }
}
