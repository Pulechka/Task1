using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                int asterisks = 0;
                while (asterisks < row)
                {
                    Console.Write("*");
                    asterisks++;
                }
                Console.WriteLine();
            }
        }
    }
}
