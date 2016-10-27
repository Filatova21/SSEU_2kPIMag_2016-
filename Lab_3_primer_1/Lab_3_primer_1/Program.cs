using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_primer_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //количество чисел
            int N;
            int x;
            Console.WriteLine("Введите количество числе для суммирования");
            if (int.TryParse(Console.ReadLine(),out N))
            {
                int Sum = 0;//сумма чисел
                for(int i = 0; i < N; i++)
                {
                    Console.WriteLine("Введите число");
                    //если введено корректное число
                    if(int.TryParse(Console.ReadLine(),out x))
                    {
                        Sum += x;//добавить к сумме
                        //Console.WriteLine("{" + Sum + "}");
                    }
                    else
                    {
                        Console.WriteLine("Неверное значение! Введите целое значение!");
                        i--;
                    };
                };
                //вывод результата
                Console.WriteLine("Сумма " + Sum);
            };

            //завершение программы
            Console.ReadKey();
        }
    }
}
