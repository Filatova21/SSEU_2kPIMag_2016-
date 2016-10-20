using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
    class Program
    {
        public static void Main(string[] args)
         
        {
           Console.WriteLine("Hello World!");
 			string userName;
 			if (args.Length > 0)
 			{
 				userName = args[0];
 			}
 			else
 			{
 				Console.Write("What's your name? ");
 				userName = Console.ReadLine();
 			};
 			Console.WriteLine("Hello, " + userName);
 			Console.Write("\nPrint any key to exit");
 			Console.ReadKey();
        }
    }
}
