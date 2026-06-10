//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System;
//using System.IO;

//class BinaryHandaling
//{
//    public static void Main(string[] args)
//    {
//        BinaryHandaling obj = new BinaryHandaling();
//        obj.Details();
//    }

//    void Details()
//    {
//        string path = "C:\\Users\\ingol\\OneDrive\\Desktop\\binaryfile.dat";

//        // Write data
//        FileStream fs = new FileStream(path, FileMode.Create);
//        BinaryWriter bw = new BinaryWriter(fs);

//        bw.Write(101);
//        bw.Write(85.5);
//        bw.Write("Yash");

//        bw.Close();
//        fs.Close();

//        // Read data
//        fs = new FileStream(path, FileMode.Open);
//        BinaryReader br = new BinaryReader(fs);

//        int id = br.ReadInt32();
//        double marks = br.ReadDouble();
//        string name = br.ReadString();

//        Console.WriteLine("ID: " + id);
//        Console.WriteLine("Marks: " + marks);
//        Console.WriteLine("Name: " + name);

//        br.Close();
//        fs.Close();
//    }
//}