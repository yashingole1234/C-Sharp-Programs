//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class EligibiltyException : Exception
//{
//    public EligibiltyException(string message) : base(message)
//    {

//    }
//    class EligibilityForVoting
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter your age:");
//            int age = Convert.ToInt32(Console.ReadLine());


//            if (age >= 18)
//            {
//                Console.WriteLine("You are eligible to vote.");
//            }
//            else
//            {
//                throw new EligibiltyException("You are eligible to vote.");
//            }

//        }
//    }
//}
