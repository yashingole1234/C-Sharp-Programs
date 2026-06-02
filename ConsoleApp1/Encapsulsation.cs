//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//     class Encapsulsation
//     {
//      private int adminid; // private variable
//      private string adminpassword;//private variable

//    public void setadmin(int adminid) // setter method
//     {
//        this.adminid = adminid;
//     }
//    public int getadminid() // getter method
//     {
//        return adminid;//instance variable
//     }
//    public static void Main()
//    {
//        Encapsulsation obj = new Encapsulsation();
//        obj.setadmin(12345);
//        Console.WriteLine("Admin ID: " + obj.getadminid());
//    }
//}

//using System;

//class Encapsulsation
//{
//    private int adminid;
//    private string adminpassword;

//    // Setter for Admin ID
//    public void setadmin(int adminid)
//    {
//        this.adminid = adminid;
//    }

//    // Getter for Admin ID
//    public int getadminid()
//    {
//        return adminid;
//    }

//    // Setter for Password
//    public void setpassword(string adminpassword)
//    {
//        this.adminpassword = adminpassword;
//    }

//    // Getter for Password
//    public string getpassword()
//    {
//        return adminpassword;
//    }

//    static void Main()
//    {
//        Encapsulsation obj = new Encapsulsation();

//        obj.setadmin(12345);
//        obj.setpassword("Admin@123");

//        Console.WriteLine("Admin ID: " + obj.getadminid());
//        Console.WriteLine("Admin Password: " + obj.getpassword());
//    }
//}