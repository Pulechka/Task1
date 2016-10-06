using System;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 3;
            int an = 999;
            int n = 999 / 3;
            double sum3 = (a1 + an) / 2.0 * n;

            a1 = 5;
            an = 995;
            n = 999 / 5;
            double sum5 = (a1 + an) / 2.0 * n;

            a1 = 15;
            an = 990;
            n = 999 / 15;
            double sum15 = (a1 + an) / 2.0 * n;

            Console.WriteLine("Sum of all numbers less than 1000 multiplies 3 or 5 = " + (int)(sum3 + sum5 - sum15));
        }
    }
}
