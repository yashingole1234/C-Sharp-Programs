////using System;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;


//class TeacherInformation
//{
//    public static void Main(string[] args)
//    {
//        TeacherInformation obj = new TeacherInformation();
//        obj.Details();
//    }

//    void Details()
//    {
//        string path = "C:\\Users\\ingol\\OneDrive\\Desktop\\TeacherInformation.txt";

//        FileStream fs = new FileStream(path, FileMode.Create);
//        StreamWriter sw = new StreamWriter(fs);

//        Console.Write("Enter Teacher Name: ");
//        string name = Console.ReadLine();

//        Console.Write("Enter Teacher Specialization: ");
//        string specialization = Console.ReadLine();

//        Console.Write("Enter Teacher City: ");
//        string city = Console.ReadLine();

//        Console.Write("Enter Institute Name: ");
//        string institute = Console.ReadLine();

//        sw.WriteLine("Teacher Name: " + name);
//        sw.WriteLine("Teacher Specialization: " + specialization);
//        sw.WriteLine("City: " + city);
//        sw.WriteLine("Institute: " + institute);

//        sw.Close();
//        fs.Close();

//        Console.WriteLine("Data Written Successfully...");
//    }
//}