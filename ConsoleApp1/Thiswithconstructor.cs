//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System;

//class Student
//{
//    string Name; // Instance Variable

//    // Constructor
//    public Student(string Name)
//    {
//        // this.Name = Instance Variable
//        // Name = Constructor Parameter

//        this.Name = Name;

//        // Store parameter value into instance variable
//    }

//    public void Display()
//    {
//        // Display current object's Name variable

//        Console.WriteLine("Student Name is : " + this.Name);

//        // this.Name refers to current object's instance variable
//    }

//    static void Main()
//    {
//        // Ask user to enter student name

//        Console.Write("Enter Student Name : ");

//        string name = Console.ReadLine();

//        // Create object
//        // Constructor is called automatically

//        Student s = new Student(name);

//        // Call Display() method

//        s.Display();

//        // Flow:
//        // Main()
//        //   ↓
//        // User enters name
//        //   ↓
//        // Student(name)
//        //   ↓
//        // this.Name = Name
//        //   ↓
//        // Value stored in instance variable
//        //   ↓
//        // Display()
//        //   ↓
//        // Student Name printed
//    }
//}
