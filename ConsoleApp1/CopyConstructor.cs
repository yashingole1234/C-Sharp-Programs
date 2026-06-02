//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class Registration
//{
//    string name;// Instance Variables
//    string emailid;
//    long phone;

//    Registration(string name, string emailid, long phone)//Constructor with parameters
//    {
//        this.name = name;// this keyword is used to refer to current object's instance variable
//        this.emailid = emailid;
//        this.phone = phone;
//    }

//    Registration(Registration r)// Copy Constructor
//    {
//        this.name = r.name;
//        this.emailid = r.emailid;
//        this.phone = r.phone;
//    }
//    public static void Main()
//    {
//        Registration r1 = new Registration("Yash", "ingoleyash123@gmail.com", 7020401535);
//        Console.WriteLine("Name: " + r1.name);
//        Console.WriteLine("Email: " + r1.emailid);
//        Console.WriteLine("Phone: " + r1.phone);

//        Console.WriteLine("-----Copy Constructor-----");
//        Registration r2 = new Registration(r1);// Copy Constructor is called
//        Console.WriteLine("Name: " + r2.name);
//        Console.WriteLine("Email: " + r2.emailid);
//        Console.WriteLine("Phone: " + r2.phone);
//    }
//}
