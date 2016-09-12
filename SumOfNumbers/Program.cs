using System;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int number = 1; number < 1000; number++)
            {
                if (number % 3 == 0 || number % 5 == 0)
                    sum += number;
            }
            Console.WriteLine("Sum of all numbers less than 1000 multiplies 3 or 5 = " + sum);
        }
    }
}
