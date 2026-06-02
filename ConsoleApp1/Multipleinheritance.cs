//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//interface yash
//{
//    public void mobile();
//}
//interface manoj
//{
//    public void laptop();

//}
//class aniket : yash, manoj
//{
//    public void mobile()
//    {
//        Console.WriteLine("Mobile is Samsung");
//    }
//    public void laptop()
//    {
//        Console.WriteLine("Laptop is Dell");
//    }

//}
//class Multipleinheritance
//{
//    public static void Main(string[] args)
//    {
//        aniket a = new aniket();
//        a.mobile();
//        a.laptop();
//    }
//}

//Task2

//using System;

//interface Payment // Parent
//{
//    void Pay();
//}

//interface Profile // Parent
//{
//    void EditProfile();
//}

//class GooglePay : Payment, Profile // Child
//{
//    public void Pay()
//    {
//        Console.WriteLine("Payment Done using Google Pay");
//    }

//    public void EditProfile()
//    {
//        Console.WriteLine("Profile Edited Successfully");
//    }
//}

//class InterfaceAbstraction
//{
//    static void Main()
//    {
//        GooglePay g = new GooglePay();

//        g.Pay();
//        g.EditProfile();
//    }
//}