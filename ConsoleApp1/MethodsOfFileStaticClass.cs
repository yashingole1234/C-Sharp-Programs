//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//class FileHandlingDemo
//{
//    public static void Main(string[] args)
//    {
//        // Creating object
//        FileHandlingDemo obj = new FileHandlingDemo();

//        // Calling method
//        obj.FileOperations();
//    }

//    void FileOperations()
//    {
//        // Original file path
//        string path = "C:\\Users\\ingol\\OneDrive\\Desktop\\Test.txt";

//        // Path for copied file
//        string copyPath = "C:\\Users\\ingol\\OneDrive\\Desktop\\CopyTest.txt";

//        // Path for moved file
//        string movePath = "C:\\Users\\ingol\\OneDrive\\Desktop\\MovedTest.txt";

//        // Write data into file
//        File.WriteAllText(path, "Hello Yash");
//        Console.WriteLine("Data Written Successfully");

//        // Append data
//        File.AppendAllText(path, "\nWelcome to File Handling");
//        Console.WriteLine("Data Appended Successfully");

//        // Read data
//        string data = File.ReadAllText(path);
//        Console.WriteLine("\nFile Content:");
//        Console.WriteLine(data);

//        // Check file exists
//        if (File.Exists(path))
//        {
//            Console.WriteLine("\nFile Exists");
//        }

//        // Copy file
//        File.Copy(path, copyPath, true);
//        Console.WriteLine("File Copied Successfully");

//        // Move file
//        File.Move(copyPath, movePath);
//        Console.WriteLine("File Moved Successfully");

//        // Delete file
//        File.Delete(movePath);
//        Console.WriteLine("Moved File Deleted Successfully");
//    }
//}