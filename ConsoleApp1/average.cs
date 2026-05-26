using System;

namespace ConsoleApp1
{
    class average
    {
        public static void Show()
        {
            int a, b, c, d;

            Console.Write("Enter 4 Numbers: ");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("Average = " + (a + b + c + d) / 4.0);
        }
    }
}