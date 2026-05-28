//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace ConsoleApp1
//{
//    // Parent Class
//    class Bank
//    {
//        public void bankName()
//        {
//            Console.WriteLine("Bank Services");
//        }
//    }

//    // Child Class 1
//    class SBI : Bank
//    {
//        public void sbiBranch()
//        {
//            Console.WriteLine("SBI Branch: Pune");
//        }
//    }

//    // Child Class 2
//    class HDFC : Bank
//    {
//        public void hdfcBranch()
//        {
//            Console.WriteLine("HDFC Branch: Mumbai");
//        }
//    }

//    // Sub Child Class
//    class Account : SBI
//    {
//        public void accountType()
//        {
//           Console.WriteLine("Account Type: Savings");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Account a = new Account();

//            a.bankName();
//            a.sbiBranch();
//            a.accountType();

//            HDFC h = new HDFC();

//            h.bankName();
//            h.hdfcBranch();
//        }
//    }
//}