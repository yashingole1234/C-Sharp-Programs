using System;

namespace ConsoleApp1
{
    class Task
    {
        public static void show()
        {

            //Console.WriteLine("*** Scholarship System ***");

            //int marks;

            //Console.WriteLine("Enter Marks:");
            //marks = Convert.ToInt32(Console.ReadLine());

            //if (marks >= 90)
            //{
            //    Console.WriteLine("Full Scholarship");
            //}
            //else if (marks >= 60)
            //{
            //    Console.WriteLine("Half Scholarship");
            //}
            //else
            //{
            //    Console.WriteLine("No Scholarship");
            //}


            //Console.WriteLine("\n*** Library Fine System ***");
            //int lateDays;

            //Console.WriteLine("Enter number of late days:");
            //lateDays = Convert.ToInt32(Console.ReadLine());

            //if (lateDays > 10)
            //{
            //    Console.WriteLine("Fine = 100");
            //}
            //else if (lateDays > 5)
            //{
            //    Console.WriteLine("Fine = 50");
            //}
            //else
            //{
            //    Console.WriteLine("No Fine");
            //}



            //Console.WriteLine("\n*** Placement Eligibility ***");
            //double cgpa;
            //Console.WriteLine("Enter CGPA:");
            //cgpa = Convert.ToDouble(Console.ReadLine());
            //bool noBacklog;
            //Console.WriteLine("Do you have any backlog? (true/false):");
            //noBacklog = Convert.ToBoolean(Console.ReadLine());

            //if (cgpa >= 7 && noBacklog)
            //{
            //    Console.WriteLine("Eligible for Placement");
            //}
            //else
            //{
            //    Console.WriteLine("Not Eligible");
            //}



            Console.WriteLine("\n*** Bus Pass System ***");
            int distance;
            Console.WriteLine("Enter distance from college (in km):");
            distance = Convert.ToInt32(Console.ReadLine());

            if (distance > 20)
            {
                Console.WriteLine("Bus Pass Approved");
            }
            else
            {
                Console.WriteLine("Not Approved");
            }



            //Console.WriteLine("\n*** Mock Interview Evaluation ***");
            //int communication;
            //Console.WriteLine("Enter Communication Skills Rating (1-10):");
            //communication = Convert.ToInt32(Console.ReadLine());
            //int technical;
            //Console.WriteLine("Enter Technical Skills Rating (1-10):");
            //technical = Convert.ToInt32(Console.ReadLine());

            //if (communication >= 8 && technical >= 8)
            //{
            //    Console.WriteLine("Selected");
            //}
            //else if (communication > 5)
            //{
            //    Console.WriteLine("Need Improvement");
            //}
            //else
            //{
            //    Console.WriteLine("Rejected");
            //}
        }
    }
}