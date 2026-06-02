//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System;

//// Student is an abstract class.
//// It contains a method declaration only.
//// Child class must provide the method body.
//abstract class StudentInfo
//{
//    public abstract void ShowInfo();
//}

//// Interface is used to define actions.
//// Any class using this interface must implement GiveExam().
//interface IExam
//{
//    void GiveExam();
//}

//// CollegeStudent inherits StudentInfo class
//// and implements IExam interface.
//class CollegeStudent : StudentInfo, IExam
//{
//    // Marks variable is private.
//    // Direct access from outside the class is not allowed.
//    private int marks;

//    // Property is used to access private variable safely.
//    public int Marks
//    {
//        get { return marks; }
//        set { marks = value; }
//    }

//    // Auto property for storing student name.
//    public string Name { get; set; }

//    // Constructor
//    // Runs automatically when object is created.
//    public CollegeStudent()
//    {
//        Console.WriteLine("College Student Object Created");
//    }

//    // This method is inherited from abstract class.
//    // We must provide its implementation here.
//    public override void ShowInfo()
//    {
//        Console.WriteLine("\n----- Student Details -----");
//        Console.WriteLine("Student Name : " + Name);
//        Console.WriteLine("Marks : " + Marks);
//    }

//    // Interface method implementation.
//    public void GiveExam()
//    {
//        Console.WriteLine("Exam Submitted Successfully");
//    }

//    // Method Overloading
//    // Same method name but no parameter.
//    public void Result()
//    {
//        Console.WriteLine("Result Declared");
//    }

//    // Method Overloading
//    // Same method name but one parameter.
//    public void Result(string grade)
//    {
//        Console.WriteLine("Grade Obtained : " + grade);
//    }
//}

//// Main class
//class Program
//{
//    static void Main()
//    {
//        // Creating object of CollegeStudent class.
//        CollegeStudent student = new CollegeStudent();

//        // Assigning values using properties.
//        student.Name = "Yash";
//        student.Marks = 85;

//        // Display student information.
//        student.ShowInfo();

//        // Calling interface method.
//        student.GiveExam();

//        // Calling first overloaded method.
//        student.Result();

//        // Calling second overloaded method.
//        student.Result("A");
//    }
//}