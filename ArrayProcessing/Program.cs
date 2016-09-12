using System;

namespace ArrayProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNums = GenerateArray(20);
            Console.WriteLine("Initial array:");
            Print(arrayOfNums);
            Console.WriteLine();
            Console.WriteLine("Max value in array is " + GetMax(arrayOfNums));
            Console.WriteLine("Min value in array is " + GetMin(arrayOfNums));
            Console.WriteLine("Array after sort:");
            Print(Sort(arrayOfNums));
        }

        public static Random rnd = new Random();

        static int[] GenerateArray(int length)
        {
            int[] arr = new int[length];
            
            for (int i = 0; i < length; i++)
                arr[i] = rnd.Next(1000);
            return arr;
        }


        static void Print(int[] arr)
        {
            foreach (var num in arr)
                Console.Write($"{num} ");
            Console.WriteLine();
        }

        static int GetMax(int[] arr)
        {
            int max = int.MinValue;
            foreach(var num in arr)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

        static int GetMin(int[] arr)
        {
            int min = int.MaxValue;
            foreach (var num in arr)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }

        static int[] Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
