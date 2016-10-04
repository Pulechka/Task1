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

            /*for (int tree = 1; tree <= n; tree++)
            {
                for (int i = 0; i < tree; i++)
                {
                    Console.WriteLine("{0," + (n + i) + "}", new string('*', 2 * i + 1));
                }
            }*/

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
