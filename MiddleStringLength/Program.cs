using System;

namespace MiddleStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Написать программу, которая определяет среднюю длину слова во введённой текстовой строке. " +
                        "Учесть, что символы пунктуации на длину слов влиять не должны.Регулярные выражения не " +
                        "использовать. И не пытайтесь прописать все ручками. Используйте стандартные методы класса String.";

            string[] wordsInStr = str.Split(new char[] { ' ', ',', '.', ':', ';', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            int wordsCount = 0;
            int wordsSummaryLength = 0;
            foreach (var word in wordsInStr)
            {
                wordsCount++;
                wordsSummaryLength += word.Length;
            }

            Console.WriteLine("String:");
            Console.WriteLine(str);
            Console.WriteLine();
            Console.WriteLine("Middle string length = " + Math.Round((double)wordsSummaryLength / wordsCount, 0));
        }
    }
}
