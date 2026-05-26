using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    class Conditional
    {
        public static void Show()
        //        {
        //            Console.WriteLine("Do You Found Bus?");
        //            bool isbusfound = bool.Parse(Console.ReadLine());

        //            if (isbusfound == true)
        //            {
        //                Console.WriteLine("Go to Class");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Go to Home");
        //            }

        //        }
        //    }
        //}
        // Nested if else statement



        //        {
        //            bool ticket = true;
        //            int age;

        //            Console.WriteLine("Enter Age:");
        //            age = int.Parse(Console.ReadLine());

        //            if (ticket)
        //            {
        //                if (age >= 18)
        //                {
        //                    Console.WriteLine("Entry allowed");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Only adults allowed");
        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine("Buy a Ticket first");
        //            }
        //        }
        //    }
        //}

        //Else If Lader

        //      

        //Switch case



        {
            Console.WriteLine("Forget your password? Login using other ways");

            Console.WriteLine("Enter Option:");
            string option = Console.ReadLine();

            switch (option)
            {
                case "Email":
                    Console.WriteLine("Login using Mail ID");
                    break;

                case "Phone":
                    Console.WriteLine("Login using Phone Number");
                    break;

                case "Aadhar":
                    Console.WriteLine("Login using Aadhar Number");
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}