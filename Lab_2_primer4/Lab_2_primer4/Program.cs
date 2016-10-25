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
                    //операции с двумя операндами
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        //считываем второй операнд
                        if(double.TryParse(Console.ReadLine(), out operand2))
                        {
                            //какая именно операция
                            switch(operation){
                                case "+": result = operand1 + operand2;break;
                                case "-": result = operand1 - operand2; break;
                                case "*": result = operand1 * operand2; break;
                                case "/": result = operand1 / operand2; break;
                            };
                        }
                        else
                        {
                            Console.WriteLine("Операнд должен быть числом!");
                        };
                        break;
                    //операция с одним операндом
                    case "sqrt":result = Math.Sqrt(operand1); break;
                        //недопустимые операции
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
