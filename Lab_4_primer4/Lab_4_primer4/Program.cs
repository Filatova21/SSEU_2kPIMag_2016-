using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4_primer4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение,разделяя слова пробелам");
            string words=Console.ReadLine();
            
            string[]wordsArr=words.Split(' ');
            Array.Sort(wordsArr);
            words=wordsArr[0];
            for(int i=0;i<wordsArr.Length;++i)
                words=words+' '+wordsArr[i];

                Console.WriteLine("Сортировка слов по алфавиту:");
                Console.WriteLine(words);
                Console.ReadKey();
        }
    }
}
