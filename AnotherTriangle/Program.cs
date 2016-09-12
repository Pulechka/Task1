using System;

namespace AnotherTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                int spaces = 0;
                while (spaces < n-row-1)
                {
                    Console.Write(' ');
                    spaces++;
                }
                int asterisks = 0;
                while (asterisks < row*2+1)
                {
                    Console.Write('*');
                    asterisks++;
                }
                Console.WriteLine();
            }
        }
    }
}
