using System;

namespace NoPositive
{
    class Program
    {
        static void Main(string[] args)
        {         
            int[,,] arrayOfNums = Generate3dArray();
            Console.WriteLine("Initial array:");
            Print(arrayOfNums);
            Console.WriteLine("Array after replace positive numbers with 0:");
            Print(ReplacePositive(arrayOfNums));
        }


        static int[,,] Generate3dArray(int demX = 2, int demY = 3, int demZ = 4)
        {
            int[,,] arr = new int[demX, demY, demZ];
            Random r = new Random();
            for (int x = 0; x <= arr.GetUpperBound(0); x++)
                for (int y = 0; y <= arr.GetUpperBound(1); y++)
                    for (int z = 0; z <= arr.GetUpperBound(2); z++)
                        arr[x, y, z] = r.Next(-100, 100);
            return arr;
        }


        static void Print(int[,,] arr)
        {
            for (int x = 0; x <= arr.GetUpperBound(0); x++)
                for (int y = 0; y <= arr.GetUpperBound(1); y++)
                    for (int z = 0; z <= arr.GetUpperBound(2); z++)
                        Console.WriteLine($"arr[{x},{y},{z}] = {arr[x,y,z]}");
            Console.WriteLine();
        }


        static int[,,] ReplacePositive(int[,,] arr)
        {
            for (int x = 0; x <= arr.GetUpperBound(0); x++)
                for (int y = 0; y <= arr.GetUpperBound(1); y++)
                    for (int z = 0; z <= arr.GetUpperBound(2); z++)
                        if (arr[x, y, z] > 0)
                            arr[x, y, z] = 0;
            return arr;
        }
    }
}
