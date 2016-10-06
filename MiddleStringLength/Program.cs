using System;
using System.Collections.Generic;
using System.Linq;

namespace MiddleStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Написать программу, которая @определяет среднюю длину слова во введённой текстовой строке. " +
                        "Учесть, что символы пунктуации на длину! слов влиять не должны.Регулярные выражения не " +
                        "использовать. И не пытайтесь прописать все ручками. Используйте стандартные методы класса String. 5-ый, 12:00";

            HashSet<char> separators = new HashSet<char>();

            foreach (var ch in str)
            {
                if (char.IsSeparator(ch) || char.IsPunctuation(ch))
                    separators.Add(ch);
            }

            string[] wordsInStr = str.Split(separators.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            int wordsSummaryLength = 0;
            foreach (var word in wordsInStr)
            {
                wordsSummaryLength += word.Length;
            }

            Console.WriteLine("String:");
            Console.WriteLine(str);
            Console.WriteLine();
            Console.WriteLine("Middle string length = " + Math.Round((double)wordsSummaryLength / wordsInStr.Length, 0));
        }
    }
}
