using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayMax
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод длины массива
            int n;
            do
            {
                Console.Write("ВВедите длину массива: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0));
            //инициализация массива
            int[] a = new int[n];
            int i = 0;
            while (i < n)
            {
                Console.Write("Введите а[" + i + "]:");
                if (int.TryParse(Console.ReadLine(), out a[i]))
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("Введите целое число");
                }; ;
            };
            //поиск максимального
            int max = a[0];
            string iMax = "0";
            for (i = 1; i < a.Length; i++)
            {
                if (a[i] == max)
                {
                    iMax = iMax + "," + i;
                }

                else if (a[i] > max)
                {
                    max = a[i];
                    iMax = i.ToString();
                };
            };
            //вывод результата
            Console.WriteLine("Максимальное значение: a[ " + iMax + "]=" + max);
            //Выход из программы
            Console.ReadKey();

        }
    }
}
