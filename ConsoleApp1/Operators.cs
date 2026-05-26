using System;

namespace ConsoleApp1
{
    class Operators
    {
        public void Show()
        {
            int a = 10, b = 5;

            Console.WriteLine("**Operator**");
            Console.WriteLine("***Arithmetic Operator***");

            Console.WriteLine("Addition = " + (a + b));
            Console.WriteLine("Subtraction = " + (a - b));
            Console.WriteLine("Multiplication = " + (a * b));
            Console.WriteLine("Division = " + (a / b));
            Console.WriteLine("Modulus = " + (a % b));

            Console.WriteLine("\n***Comparison Operator***");

            Console.WriteLine("a == b : " + (a == b));
            Console.WriteLine("a != b : " + (a != b));
            Console.WriteLine("a > b : " + (a > b));
            Console.WriteLine("a < b : " + (a < b));
            Console.WriteLine("a >= b : " + (a >= b));
            Console.WriteLine("a <= b : " + (a <= b));
        }
    }
}