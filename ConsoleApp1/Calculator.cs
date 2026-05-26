using System;

namespace ConsoleApp1
{
    class Calculator
    {
        public void Show()
        {
            int a, b;

            Console.WriteLine("* Mini Calculator *");

            Console.Write("Enter First Number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition = " + (a + b));
            Console.WriteLine("Subtraction = " + (a - b));
            Console.WriteLine("Multiplication = " + (a * b));
            Console.WriteLine("Division = " + (a / b));
        }
    }
}