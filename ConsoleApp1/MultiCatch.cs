//using System;

//class MultiCatch
//{
//    public static void Main(string[] args)
//    {
//        int a = 30;
//        int b = 0;

//        string str = null;

//        try
//        {
//            int c = a / b;   // DivideByZeroException

//            try
//            {
//                int count = str.Length;   // NullReferenceException
//            }
//            catch (NullReferenceException e)
//            {
//                Console.WriteLine("String is Null");
//            }
//        }
//        catch (DivideByZeroException e)
//        {
//            Console.WriteLine("Division by zero is not allowed!!");
//        }

//        Console.WriteLine("Program Ended");
//    }
//}