//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    class callbyreferance
//    {
//        static void displaynum(ref int n1)
//        {
//            n1 = 75;
//            Console.WriteLine("the value of n1 is:" + n1);
//        }
//        public static void Main(string[] args)
//        {
//            int org_num = 80;
//            Console.WriteLine("The value of org_num before calling the method: " + org_num);

//            displaynum(ref org_num);
//            Console.WriteLine("The value of org_num after calling the method: " + org_num);
//        }
//    }
//}
