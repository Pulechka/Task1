using System;

namespace X_MasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());

            for (int tree = 1; tree <= n; tree++)
            {
                for (int i = 0; i < tree; i++)
                {
                    Console.WriteLine("{0," + (n + i) + "}", new string('*', 2 * i + 1));
                }
            }
        }
    }
}
