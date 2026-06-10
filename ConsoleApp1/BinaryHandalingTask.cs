//using System;
//using System.IO;

//class BinaryHandalingTask
//{
//    public static void Main(string[] args)
//    {
//        BinaryHandalingTask obj = new BinaryHandalingTask();
//        obj.Details();
//    }

//    void Details()
//    {
//        string path = "C:\\Users\\ingol\\OneDrive\\Desktop\\Taskbinaryfile.dat";

//        Console.Write("Enter ID: ");
//        int id = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Enter Marks: ");
//        double marks = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Enter Name: ");
//        string name = Console.ReadLine();

//        FileStream fs = new FileStream(path, FileMode.Create);
//        BinaryWriter bw = new BinaryWriter(fs);

//        bw.Write(id);
//        bw.Write(marks);
//        bw.Write(name);

//        bw.Close();
//        fs.Close();

//        Console.WriteLine("Data written successfully.");

//        FileStream fa = new FileStream(path, FileMode.Open);
//        BinaryReader br = new BinaryReader(fa);

//        Console.WriteLine("ID: " + br.ReadInt32());
//        Console.WriteLine("Marks: " + br.ReadDouble());
//        Console.WriteLine("Name: " + br.ReadString());

//        br.Close();
//        fa.Close();
//    }
//}