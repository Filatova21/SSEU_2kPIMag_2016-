﻿using System;
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
            //поиск минимального
            int min = a[0];
            string iMin = "0";
            for (i = 1; i < a.Length; i++)
            {
                if (a[i] == min)
                {
                    iMin = iMin + "," + i;
                }

                else if (a[i] < min)
                {
                    min = a[i];
                    iMin = i.ToString();
                };
            };
            //вывод результата
            Console.WriteLine("Минимальное значение: a[ " + iMin + "]=" + min);
            for (i = 0; i < a.Length; i++) {
                if (a[i]==min)
                {
                    Console.WriteLine("a["+i+"] = "+"0");
                }
                else 
                {
                    Console.WriteLine("a[" + i + "] = " + a[i]);
                };
            };
            //Выход из программы
            Console.ReadKey();
        }
    }
}
