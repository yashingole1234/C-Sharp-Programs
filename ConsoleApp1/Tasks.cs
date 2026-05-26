using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tasks
    {
        public static void Show()
        //{
        //        {
        //            int[] arr = { 12, 23, 34, 45, 56 };
        //            int ele = 23;
        //            int found = 0;

        //            for (int i = 0; i < arr.Length; i++)
        //            {
        //                if (arr[i] == ele)
        //                {
        //                    Console.WriteLine("Index of 23 is: " + i);
        //                    found = 1;
        //                    break;
        //                }
        //            }

        //            if (found == 0)
        //            {
        //                Console.WriteLine("Element not found");
        //            }
        //        }
        //    }

        //}
        //}


        //            {
        //                char[] ch = new char[5];

        //                Console.WriteLine("Enter 5 characters:");

        //                for (int i = 0; i < 5; i++)
        //                {
        //                    ch[i] = Convert.ToChar(Console.ReadLine());
        //                }

        //                Console.WriteLine("Vowels in array are:");

        //                for (int i = 0; i < 5; i++)
        //                {
        //                    if (ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' ||
        //                        ch[i] == 'o' || ch[i] == 'u' ||
        //                        ch[i] == 'A' || ch[i] == 'E' || ch[i] == 'I' ||
        //                        ch[i] == 'O' || ch[i] == 'U')
        //                    {
        //                        Console.WriteLine(ch[i]);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        //        {
        //            int[] arr = new int[5];

        //            Console.WriteLine("Enter 5 numbers:");

        //            for (int i = 0; i < 5; i++)
        //            {
        //                arr[i] = Convert.ToInt32(Console.ReadLine());
        //            }

        //            Console.WriteLine("Odd elements are:");

        //            for (int i = 0; i < 5; i++)
        //            {
        //                if (arr[i] % 2 != 0)
        //                {
        //                    Console.WriteLine(arr[i]);
        //                }
        //            }
        //        }
        //    }
        //}


        {
            int[] arr = new int[5];

            Console.WriteLine("Enter 5 elements:");

            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Reverse Array:");

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
