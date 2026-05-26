namespace ConsoleApp1
{
    internal class Count
    //    {
    //        public static void Show()
    //        {
    //            int num, count = 0;

    //            Console.WriteLine("Enter a Number:");
    //            num = Convert.ToInt32(Console.ReadLine());

    //            while (num > 0)
    //            {
    //                num = num / 10;
    //                count++;
    //            }

    //            Console.WriteLine("Total Digits = " + count);
    //        }
    //    }
    //}
    {
        public static void Show()
        //{
        //    int num, sum = 0, rem;

        //    Console.WriteLine("Enter a Number:");
        //    num = Convert.ToInt32(Console.ReadLine());

        //    while (num > 0)
        //    {
        //        rem = num % 10;   // get last digit
        //        sum = sum + rem;  // add digit
        //        num = num / 10;   // remove last digit
        //    }

        //    Console.WriteLine("Sum of Digits = " + sum);
        //        {
        //            {
        //                int i = 1;

        //                do
        //                {
        //                    if (i % 2 != 0)
        //                    {
        //                        Console.WriteLine(i);
        //                    }

        //                    i++;
        //                }
        //                while (i <= 20);
        //            }
        //        }

        //    }
        //}


        //        {
        //            int num;

        //            Console.WriteLine("Enter a Number:");
        //            num = Convert.ToInt32(Console.ReadLine());

        //            Console.WriteLine("Reverse Number Series:");

        //            for (int i = num; i >= 1; i--)
        //            {
        //                Console.WriteLine(i);
        //            }
        //        }
        //    }
        //}

        {
            int start, end;

            Console.WriteLine("Enter Start Number:");
            start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter End Number:");
            end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Reverse Number Series:");

            for (int i = start; i >= end; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}


