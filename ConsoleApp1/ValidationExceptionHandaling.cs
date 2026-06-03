//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//using System;
//class ValidationExceptionHandaling
//{
//    public static void Main(string[] args)
//    {
//        int a = 30;
//        int b = 0;
//        int c = 0;

//        string str = null;

//        try
//        {
//            try
//            {
//                  int count = str.Length;   // NullReferenceException
//                c = a / b;            // DivideByZeroException
//            }
//          finally
//            {
//                Console.WriteLine("This block will always be executed!!");
//            }
//            Catch(NullReferenceException e)
//            {
//                Console.WriteLine("String is Null");
//            }
//            catch (DivideByZeroException e)
//            {
//                Console.WriteLine("Division by zero is not allowed!!");
//            }