using System;
using System.Linq;
using System.Text;

namespace CharDoubler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");
            string firstString = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string secondString = Console.ReadLine();

            //StringBuilder strBuilder = new StringBuilder();
            //foreach (var ch in secondString)
            //{
            //    if (!strBuilder.ToString().Contains(ch.ToString()))
            //        strBuilder.Append(ch);
            //}

            char[] charsForDouble = secondString.Distinct().ToArray();

            foreach (var ch in charsForDouble.ToString())
            {
                firstString = firstString.Replace(ch.ToString(), string.Format("{0}{1}",ch,ch));       
            }
            
            Console.WriteLine("Результирующая строка: "+ firstString);
        }
    }
}
