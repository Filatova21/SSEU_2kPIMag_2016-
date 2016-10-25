using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1, operand2;//операнды
            double result=0;//результат вычисления
            string operation;//действие
            Console.WriteLine("Введите первое число");
            if ((double.TryParse(Console.ReadLine(),out operand1)))
            {
                //выбираем операцию
                Console.WriteLine("Введите операцию");
                operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        Console.WriteLine("Введите второе число");
                        if (double.TryParse(Console.ReadLine(), out operand2)){
                            result = operand1 + operand2;
                        }; break;
                    case "-":
                        Console.WriteLine("Введите второе число");
                        if (double.TryParse(Console.ReadLine(), out operand2))
                        {
                            result = operand1 - operand2;
                        };
                        break;
                    case "*":
                        Console.WriteLine("Введите второе число");
                        if (double.TryParse(Console.ReadLine(), out operand2))
                        {
                            result = operand1 * operand2;
                        };
                        break;
                    case "/":
                        Console.WriteLine("Введите второе число");
                        if (double.TryParse(Console.ReadLine(), out operand2))
                        {
                            result = operand1 / operand2;
                        };break;
                    case "sqrt":result = Math.Sqrt(operand1); break;
                    default:Console.WriteLine("неверная операция");
                        Console.ReadKey();
                        return;
                };
                //выводим результат
                Console.WriteLine("Результат = "+result);
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Операнд должен быть числом!");

            };

        }
    }
}
