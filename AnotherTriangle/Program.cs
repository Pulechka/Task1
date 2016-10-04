using System;
using System.Text;

namespace AnotherTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());

            /*for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0,"+(n+i)+"}", new string('*', 2*i + 1));
            }*/

            StringBuilder sb = new StringBuilder();
            sb.Append('*');
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0," + (n + i) + "}", sb);
                sb.Append('*', 2);
            }
        }
    }
}
