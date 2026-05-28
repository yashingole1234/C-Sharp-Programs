    
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C_Sharp_Programs
//{

//    class Employee // Parent Class
//    {
//        public virtual void Bonus()
//        {
//            Console.WriteLine("Employee Bonus");
//        }
//    }

//    class HR : Employee // Child Class
//    {
//        public override void Bonus()
//        {
//            Console.WriteLine("HR Bonus = 10000");
//        }
//    }

//    class Developer : Employee // Child Class
//    {
//        public override void Bonus()
//        {
//            Console.WriteLine("Developer Bonus = 20000");
//        }
//    }

//    class Tester : Employee// Child Class
//    {
//        public override void Bonus()
//        {
//            Console.WriteLine("Tester Bonus = 15000");
//        }

//        class Technicaian:Tester// Child Class
//        {
//            public override void Bonus()
//            {
//                Console.WriteLine("Technical Support Bonus = 12000");
//            }
//    }
//    class OverridingTask// Main Class
//        {
//            static void Main(string[] args)// Main Methoda
//            {
//                Employee employee = new Employee();
//                employee.Bonus();
//                HR hr = new HR();
//                hr.Bonus();
//                Developer developer = new Developer();
//                developer.Bonus();
//                Tester tester = new Tester();
//                tester.Bonus();
//                Technicaian technicalSupport = new Technicaian();
//                technicalSupport.Bonus();
//            }
//        }
//    }
//}


