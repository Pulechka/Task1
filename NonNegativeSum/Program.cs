using System;

namespace NonNegativeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNums = GenerateArray(length:20);
            Console.WriteLine("Initial array:");
            Print(arrayOfNums);
            Console.WriteLine("Sum of non-negative numbers = " + GetNonNegativeSum(arrayOfNums));
        }


        static int[] GenerateArray(int length)
        {
            int[] arr = new int[length];
            Random r = new Random();
            for (int i = 0; i < length; i++)
                arr[i] = r.Next(-100,100);
            return arr;
        }
        

        static void Print(int[] arr)
        {
            foreach (var num in arr)
                Console.Write($"{num} ");
            Console.WriteLine();
        }

        static int GetNonNegativeSum(int[] arr)
        {
            int sum = 0;
            foreach (var num in arr)
            {
                if (num > 0)
                    sum += num;
            }
            return sum;
        }
    }
}
