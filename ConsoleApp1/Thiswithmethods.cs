//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System;

//class ATM
//{
//    string AccountHolder; // Instance Variable

//    public void Login() // Login Method
//    {
//        // Ask user to enter account holder name

//        Console.Write("Enter Account Holder Name : ");

//        // Store user input into instance variable

//        AccountHolder = Console.ReadLine();

//        // Call ShowAccount() method using this keyword

//        this.ShowAccount();

//        // this = current object
//        // ShowAccount() belongs to same class
//        // Current object calls ShowAccount() method
//    }

//    public void ShowAccount() // ShowAccount Method
//    {
//        // Display current object's AccountHolder variable

//        Console.WriteLine("Account Holder Name is " + this.AccountHolder);

//        // this.AccountHolder refers to
//        // current object's instance variable
//    }

//    static void Main()
//    {
//        // Create object of ATM class

//        ATM a = new ATM();

//        // Call Login() method using object

//        a.Login();

//        // Flow:
//        // Main()
//        //   ↓
//        // Login()
//        //   ↓
//        // User enters account holder name
//        //   ↓
//        // this.ShowAccount()
//        //   ↓
//        // ShowAccount()
//        //   ↓
//        // Welcome Message Displayed
//    }
//}
