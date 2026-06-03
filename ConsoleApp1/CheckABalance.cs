//using System;

//class CheckAvaliableBalanceException : Exception
//{
//    public CheckAvaliableBalanceException(string message) : base(message)
//    {
//    }
//}

//class CheckABalance
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter your account balance:");
//        int balance = Convert.ToInt32(Console.ReadLine());

//        if (balance <= 5000)
//        {
//            throw new CheckAvaliableBalanceException("Your balance is insufficient for the transaction.");
//        }
//        else
//        {
//            Console.WriteLine("Your balance is sufficient for the transaction.");
//            Console.WriteLine("Balance = " + balance);
//        }
//    }
//}