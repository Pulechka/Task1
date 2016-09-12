using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Enter side a:");
            while (!int.TryParse(Console.ReadLine(), out a)) { }

            Console.WriteLine("Enter side b:");
            while (!int.TryParse(Console.ReadLine(), out b)) { }

            if (a <= 0 || b <= 0)
                Console.WriteLine("Invalide value!!!");
            else
                Console.WriteLine($"Square of rectangle with sides {a} and {b} = {a * b}");
        }
    }
}
