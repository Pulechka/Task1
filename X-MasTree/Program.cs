using System;
using System.Text;

namespace X_MasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            for (int tree = 1; tree <= n; tree++)
            {
                sb.Append('*');
                for (int i = 0; i < tree; i++)
                {
                    Console.WriteLine("{0," + (n + i) + "}", sb);
                    sb.Append('*', 2);
                }
                sb.Clear();
            }
        }
    }
}
