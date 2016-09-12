using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayOfNums = Generate2DArray(4, 6);
            Console.WriteLine("Initial array:");
            Print(arrayOfNums);
            Console.WriteLine("\nSum of numbers in even positions = " + GetSumFromEvenPosition(arrayOfNums));
        }


        static int[,] Generate2DArray(int rowCount, int columnCount)
        {
            int[,] arr = (int[,])Array.CreateInstance(typeof(int), new int[] { rowCount, columnCount }, new int[] { 1, 1 });
            Random r = new Random();
            for (int i = 1; i <= rowCount; i++)
                for (int j = 1; j <= columnCount; j++)
                    arr[i, j] = r.Next(20);
            return arr;
        }


        static void Print(int[,] arr)
        {
            for (int i = 1; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 1; j <= arr.GetUpperBound(1); j++)
                {
                    Console.Write($"{arr[i, j],2} ");
                }
                Console.WriteLine();
            }
        }

        static int GetSumFromEvenPosition(int[,] arr)
        {
            int sum = 0;
            for (int i = 1; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 1; j <= arr.GetUpperBound(1); j++)
                {
                    if ((i + j) % 2 == 0)
                        sum += arr[i, j];
                }
            }
            return sum;
        }
    }
}
