//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//class Writefile
//{
//    public static void Main(string[] args)
//    {
//        Writefile obj = new Writefile();
//        obj.myfile();
//    }

//    void myfile()
//    {
//        string path = "C:\\Users\\ingol\\OneDrive\\Desktop\\writeline.txt";
//        FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
//        StreamWriter sw = new StreamWriter(fs);
//        sw.WriteLine("Welcome to C# Programming");
//        sw.WriteLine("This is a sample text file.");
      
//        sw.Close();
//        fs.Close();
//        Console.WriteLine("Data written to file successfully.");
//    }
//}
