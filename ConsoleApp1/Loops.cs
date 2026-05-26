using System;

namespace ConsoleApp1
{
    class Loops
    {
        public static void Show()
        //        {
        //            int i = 1;

        //            while (i <= 10)
        //            {
        //                Console.WriteLine(i);
        //                i++;
        //            }
        //        }
        //    }
        //}

        {
            int num, count = 0;

            Console.WriteLine("Enter a Number:");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }
    }
}


