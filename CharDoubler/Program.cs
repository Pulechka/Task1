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

            char[] charsForDouble = secondString.Distinct().ToArray();

            StringBuilder sb = new StringBuilder(firstString);      
            
            foreach (var ch in charsForDouble)
            {
                sb.Replace(ch.ToString(), string.Format("{0}{1}", ch, ch));
            }
            
            Console.WriteLine("Результирующая строка: "+ sb);
        }
    }
}
