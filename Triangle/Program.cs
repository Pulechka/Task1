using System;
using System.Text;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());

            /*for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*',i));
            }*/

            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < n; i++)
            {
                sb.Append('*');
                Console.WriteLine(sb);
            }
        }
    }
}
