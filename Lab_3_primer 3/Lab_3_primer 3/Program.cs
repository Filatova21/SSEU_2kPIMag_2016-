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
            int max = a[0];
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
            //сортировка массива
            for (i = 0; i < a.Length - 1; ++i)
            {
                for (int j = 1; j < a.Length; ++j)
                {
                    if (a[j - 1] > a[j])
                    {
                        int buf = a[j];
                        a[j] = a[j - 1];
                        a[j - 1] = buf;
                    };
                };
            };
            //вывод отсортированного массива
            Console.WriteLine("Отсортированный массив:");
            for (i = 0; i < a.Length; ++i)
            {
                Console.WriteLine(a[i]);
            };

            //Выход из программы
            Console.ReadKey();
        }
    }
}
