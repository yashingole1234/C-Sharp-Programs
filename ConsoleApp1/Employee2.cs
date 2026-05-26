////using System;

////namespace ConsoleApp1
////{
////    class Employee
////    {
////        public int Id;
////        public string Name;
////        public int Salary;

////        public static void Main(string[] args)
////        {
////            Employee[] emp = new Employee[3];

////            // Input Employee Details
////            for (int i = 0; i < 3; i++)
////            {
////                emp[i] = new Employee();

////                bool duplicate;

////                do
////                {
////                    duplicate = false;

////                    Console.WriteLine("\nEnter Employee ID:");
////                    int newId = Convert.ToInt32(Console.ReadLine());

////                    // Check duplicate ID
////                    for (int j = 0; j < i; j++)
////                    {
////                        if (emp[j].Id == newId)
////                        {
////                            duplicate = true;
////                            Console.WriteLine("Duplicate ID found! Enter different ID.");
////                            break;
////                        }
////                    }

////                    if (!duplicate)
////                    {
////                        emp[i].Id = newId;
////                    }

////                } while (duplicate);

////                Console.WriteLine("Enter Employee Name:");
////                emp[i].Name = Console.ReadLine();

////                Console.WriteLine("Enter Employee Salary:");
////                emp[i].Salary = Convert.ToInt32(Console.ReadLine());
////            }

////            // Search Employee
////            Console.WriteLine("\nEnter Employee ID to Search:");
////            int searchId = Convert.ToInt32(Console.ReadLine());

////            bool found = false;

////            for (int i = 0; i < 3; i++)
////            {
////                if (emp[i].Id == searchId)
////                {
////                    found = true;

////                    Console.WriteLine("\nEmployee Found");
////                    Console.WriteLine("Employee ID: " + emp[i].Id);
////                    Console.WriteLine("Employee Name: " + emp[i].Name);
////                    Console.WriteLine("Employee Salary: " + emp[i].Salary);

////                    break;
////                }
////            }

////            if (!found)
////            {
////                Console.WriteLine("Employee ID not found");
////            }
////        }
////    }
////}

//using System;

//namespace ConsoleApp1
//{
//    class Employee
//    {
//        public int Id;
//        public string Name;
//        public int Salary;

//        public static void Main(string[] args)
//        {
//            Console.WriteLine("How many employees?");
//            int n = Convert.ToInt32(Console.ReadLine());

//            Employee[] emp = new Employee[n];

//            // Input Employee Details
//            for (int i = 0; i < n; i++)
//            {
//                emp[i] = new Employee();

//                bool duplicate;

//                do
//                {
//                    duplicate = false;

//                    Console.WriteLine("\nEnter Employee ID:");
//                    int newId = Convert.ToInt32(Console.ReadLine());

//                    // Check duplicate ID
//                    for (int j = 0; j < i; j++)
//                    {
//                        if (emp[j].Id == newId)
//                        {
//                            duplicate = true;

//                            Console.WriteLine("Duplicate ID found! Enter different ID.");
//                            break;
//                        }
//                    }

//                    if (!duplicate)
//                    {
//                        emp[i].Id = newId;
//                    }

//                } while (duplicate);

//                Console.WriteLine("Enter Employee Name:");
//                emp[i].Name = Console.ReadLine();

//                Console.WriteLine("Enter Employee Salary:");
//                emp[i].Salary = Convert.ToInt32(Console.ReadLine());
//            }

//            // Search Employee
//            Console.WriteLine("\nEnter Employee ID to Search:");
//            int searchId = Convert.ToInt32(Console.ReadLine());

//            bool found = false;

//            for (int i = 0; i < n; i++)
//            {
//                if (emp[i].Id == searchId)
//                {
//                    found = true;

//                    Console.WriteLine("\nEmployee Found");

//                    Console.WriteLine("Employee ID: " + emp[i].Id);
//                    Console.WriteLine("Employee Name: " + emp[i].Name);
//                    Console.WriteLine("Employee Salary: " + emp[i].Salary);

//                    break;
//                }
//            }

//            if (!found)
//            {
//                Console.WriteLine("Employee ID not found");
//            }
//        }
//    }
//}