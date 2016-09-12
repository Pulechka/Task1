using System;

namespace X_MasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());

            //draw the first asterisk
            for (int i = 0; i < n; i++)
                Console.Write(' ');
            Console.WriteLine('*');

            for (int tree = 1; tree <= n; tree++)
            {
                for (int row = 0; row <= n; row++)
                {
                    int spaces = 0;
                    while (spaces < n - row)
                    {
                        Console.Write(' ');
                        spaces++;
                    }

                    int asterisks = 0;
                    while (asterisks < row * 2 + 1)
                    {
                        Console.Write('*');
                        asterisks++;
                    }

                    Console.WriteLine();
                    if (asterisks == tree * 2 + 1)
                        break;
                }
            }
        }
    }
}
