using System;
using System.Collections.Generic;
using System.Text;

namespace FIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string imya = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string otchestvo = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string familiya = Console.ReadLine();
            //И.О.Фамилия
            if (!string.IsNullOrEmpty(otchestvo))//если отчество ввели
            {
                Console.Write(imya[0].ToString().ToUpper()
                              + "." + otchestvo[0].ToString().ToUpper()
                              + "." + familiya[0].ToString().ToUpper()
                              + familiya.Substring(1).ToLower());
            }
            else {
                Console.Write(imya[0].ToString().ToUpper()
                              + "." + familiya[0].ToString().ToUpper()
                              + familiya.Substring(1).ToLower());
            };
            
            //Фамилия И.О.
            if (!string.IsNullOrEmpty(otchestvo))//если отчество ввели
            {
                Console.WriteLine(familiya[0].ToString().ToUpper()
                    + familiya.Substring(1).ToLower() + " "
                    + imya[0].ToString().ToUpper() + "."
                    + otchestvo[0].ToString().ToUpper() + ".");
            }
            else {
                Console.WriteLine(familiya[0].ToString().ToUpper()
                                    + familiya.Substring(1).ToLower() + " "
                                    + imya[0].ToString().ToUpper() + ".");
            };
            
            //Имя Отчество ФАМИЛИЯ
            if (!string.IsNullOrEmpty(otchestvo))//если отчество ввели
            {
                Console.WriteLine(imya[0].ToString().ToUpper()
                    + imya.Substring(1).ToLower() + " "
                    + otchestvo[0].ToString().ToUpper()
                    + otchestvo.Substring(1).ToLower() + " "
                    + familiya.ToUpper());
            }
            else {
                Console.WriteLine(imya[0].ToString().ToUpper()
                    + imya.Substring(1).ToLower() + " "
                    + familiya.ToUpper());
            };
            //фам_и_о
            if (!string.IsNullOrEmpty(otchestvo))//если отчество ввели
            {
                Console.WriteLine((familiya.Substring(0, 3) + "_"
                    + imya.Substring(0, 1) + "_"
                    + otchestvo.Substring(0, 1)).ToLower());
            }
            else {
                Console.WriteLine((familiya.Substring(0, 3) + "_"+ imya.Substring(0, 1)));
            };

            Console.ReadKey();
        }
    }
}
