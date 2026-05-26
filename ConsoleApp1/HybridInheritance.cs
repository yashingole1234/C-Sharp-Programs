using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    // Parent Class
    class Bank
    {
        public void bankName()
        {
            Console.WriteLine("Bank Name: SBI");
        }
    }

    // Child Class
    class SBI : Bank
    {
        public void branch()
        {
            Console.WriteLine("Branch: Pune Branch");
        }
    }

    // Sub Child Class
    class Account : SBI
    {
        public void accountType()
        {
            Console.WriteLine("Account Type: Savings Account");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account obj = new Account();

            obj.bankName();
            obj.branch();
            obj.accountType();
        }
    }
}