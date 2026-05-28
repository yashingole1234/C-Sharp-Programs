//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C_Sharp_Programs
//{
//    class overriding
//    {
//    }

//namespace ConsoleApp1
//    {
//        // Parent Class
//        class Company
//        {
//            public virtual void Details()
//            {
//                Console.WriteLine("Employees work in company:Acenture");
//            }
//        }

//        // Child Class
//        class Employee : Company
//        {
//            public override void Details()
//            {
//                base.Details(); // Call the base class method
//                Console.WriteLine("Employee works as Dot Net Developer");
//            }
//        }

//        class Overriding
//        {
//            static void Main(string[] args)
//            {
//                Employee emp = new Employee();
//                emp.Details(); // This will call the overridden method in the Employee class


//            }
//        }
//    }
//}

