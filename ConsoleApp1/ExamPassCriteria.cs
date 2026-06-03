//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;



//// Custom Exception Class
//class FailException : Exception
//{
//    // Constructor to pass custom message to base Exception class
//    public FailException(string message) : base(message)
//    {
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Accept marks from user
//        Console.Write("Enter Marks: ");
//        int marks = Convert.ToInt32(Console.ReadLine());

//        // Check whether student passed or failed
//        if (marks >= 35)
//        {
//            // Student has passed the exam
//            Console.WriteLine("Pass");
//        }
//        else
//        {
//            // Student has failed, so throw custom exception
//            throw new FailException("Fail In Exam");
//        }
//    }
//}