using System;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum3 = GetSumOfArithmeticalProgression(a1: 3, an: 999, n: 999 / 3);
            int sum5 = GetSumOfArithmeticalProgression(a1: 5, an: 995, n: 999 / 5);
            int sum15 = GetSumOfArithmeticalProgression(a1: 15, an: 990, n: 999 / 15);

            Console.WriteLine("Sum of all numbers less than 1000 multiplies 3 or 5 = " + (sum3 + sum5 - sum15));
        }

        static int GetSumOfArithmeticalProgression(int a1, int an, int n) => (int)((a1 + an) / 2.0 * n);
    }
}
