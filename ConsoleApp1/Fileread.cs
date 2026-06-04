//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class fileread
//{
//    public static void Main(string[] args)
//    {
//        fileread obj = new fileread();
//        obj.read();
//    }
//    void read()
//    {
//        string path = "C:\\Users\\ingol\\OneDrive\\Desktop\\Writeline.txt";
//        FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
//        StreamReader sr = new StreamReader(fs);
//        string alldata = sr.ReadToEnd();
//        Console.WriteLine("Data read done");
//        Console.WriteLine("After reading:"+alldata);
//        sr.Close();
//        fs.Close();
//    }
//}