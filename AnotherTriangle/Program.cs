using System;
using System.Text;

namespace AnotherTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = GetN();
            PrintTriangle(n);
        }


        static int GetN()
        {
            Console.WriteLine("Enter N:");
            return int.Parse(Console.ReadLine());
        }


        static void PrintTriangle(int n)
        {
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
