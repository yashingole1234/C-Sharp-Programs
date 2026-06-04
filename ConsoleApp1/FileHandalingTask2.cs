using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class UserInformation
{
    public static void Main(string[] args)
    {
        UserInformation obj = new UserInformation();
        obj.Details();
    }

    void Details()
    {
        string path = "C:\\Users\\ingol\\OneDrive\\Desktop\\UserInformation.txt";

        FileStream fs = new FileStream(path, FileMode.Create);
        StreamWriter sw = new StreamWriter(fs);

        Console.Write("Enter Number of Users: ");
        int count = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= count; i++)
        {
            Console.WriteLine("\nEnter Details of User " + i);

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Date of Birth: ");
            string dob = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            string phone = Console.ReadLine();

            Console.Write("Enter Mail ID: ");
            string mail = Console.ReadLine();

            Console.Write("Enter Aadhar Card Number: ");
            string aadhar = Console.ReadLine();

            Console.Write("Enter PAN Card Number: ");
            string pan = Console.ReadLine();

            sw.WriteLine("User " + i);
            sw.WriteLine("Name: " + name);
            sw.WriteLine("Date of Birth: " + dob);
            sw.WriteLine("Phone Number: " + phone);
            sw.WriteLine("Mail ID: " + mail);
            sw.WriteLine("Aadhar Card Number: " + aadhar);
            sw.WriteLine("PAN Card Number: " + pan);
            sw.WriteLine("----------------------------------");
        }

        sw.Close();
        fs.Close();

        Console.WriteLine("\nAll User Details Stored Successfully...");
    }
}
