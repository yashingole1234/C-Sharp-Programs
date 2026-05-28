//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C_Sharp_Programs
//{
//    class MethodOverloading
//    {
//        void bill_payment()// 1.passing no parameters
//        {
//            Console.WriteLine("Electricity Bill Payment:");
//        }
//        void bill_payment(int amount)// 2.passing single parameter
//        {
//            Console.WriteLine("Water Bill Payment: ");
//        }
//        void bill_payment(string bill_type)// 3.passing single parameter with different data type
//        {
//            Console.WriteLine("Gas Bill Payment: ");
//        }
//        void bill_payment(int amount, string bill_type)// 4.passing two parameters
//        {
//            Console.WriteLine("Internet Bill Payment: ");
//        }
//        void bill_payment(string bill_type, int amount)// 5.passing two parameters with different sequence
//        {
//            Console.WriteLine("Mobile Bill Payment: ");
//        }
//        public static void Main(string[] args)
//        {
//            MethodOverloading m = new MethodOverloading();  
//            m.bill_payment();
//            m.bill_payment(500);
//            m.bill_payment("GAS");
//            m.bill_payment(1000, "Internet");
//            m.bill_payment("Mobile", 200);
//        }
//    }
//}
