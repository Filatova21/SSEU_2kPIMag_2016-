using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int max;
            if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b) && int.TryParse(Console.ReadLine(), out c)) {
                //Если а>=b
                if (a >= b)
                {
                    //и если а>=с
                    if (a >= c)
                    {
                        //то максимальное-а
                        max = a;
                    }
                    //иначе с>a
                    else
                    {
                        //максимальное с
                        max = c;
                    }
                }
                //иначе больше b
                else
                {
                    //и если b>=c
                    if (b >= c)
                    {
                        //то максимальное B
                        max = b;
                    }
                    else
                    {
                        max = c;
                    };
                };
                //Вывод результата
                Console.WriteLine("Максимальное = " + max);
            }
            else
                {
                    Console.WriteLine("Неверное значение!Нужно ввести целое число");
                };
           
            Console.ReadKey();

        }
    }
}