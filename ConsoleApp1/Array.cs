using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Array
    {

        public static void Show()
        {

            //{
            //    public static void Show()
            //    {
            //        int[] nums = { 50, 55, 60, 61 };
            //        Console.WriteLine("length of array: " + nums.Length);   
            //        for (int i = 0; i < nums.Length; i++)
            //        {
            //            Console.WriteLine(nums[i]);
            //        }
            //    }
            //}
            //{
            //    public static void Show()
            //        {
            //            int [] phno = new int[5];
            //            phno[0]= 1234567890;
            //            phno[1] = 9876543;
            //            phno[2] = 555555;
            //            phno[3] = 111111; ;
            //            phno[4] = 999999;

            //            int index = 0;
            //            while (index < phno.Length)
            //            {
            //                Console.WriteLine(phno[index]);
            //                index++;
            //            }


            //        }
            //    }

            //}


            //            {
            //                int size, sum = 0;

            //                Console.WriteLine("Enter Array Size:");
            //                size = Convert.ToInt32(Console.ReadLine());

            //                int[] arr = new int[size];

            //                Console.WriteLine("Enter Array Elements:");

            //                for (int i = 0; i < size; i++)
            //                {
            //                    arr[i] = Convert.ToInt32(Console.ReadLine());
            //                }

            //                Console.WriteLine("Array Elements are:");

            //                for (int i = 0; i < size; i++)
            //                {
            //                    Console.Write(arr[i] + " ");
            //                    sum = sum + arr[i];
            //                }

            //                Console.WriteLine("\nAddition of Group Elements = " + sum);
            //            }
            //        }
            //    }
            //}




            //            {

            //                int[] numbers = new int[20];


            //                numbers[0] = 10;
            //                numbers[1] = 20;
            //                numbers[2] = 30;
            //                numbers[3] = 40;
            //                numbers[4] = 50;
            //                numbers[5] = 60;
            //                numbers[6] = 70;
            //                numbers[7] = 80;
            //                numbers[8] = 90;
            //                numbers[9] = 100;
            //                numbers[10] = 110;
            //                numbers[11] = 120;
            //                numbers[12] = 130;
            //                numbers[13] = 140;
            //                numbers[14] = 150;
            //                numbers[15] = 160;
            //                numbers[16] = 170;
            //                numbers[17] = 180;
            //                numbers[18] = 190;
            //                numbers[19] = 200;

            //                int index = 15;

            //                Console.WriteLine("Element at Index 15 is:");
            //                Console.WriteLine(numbers[index]);
            //            }
            //        }
            //    }
            //}

            //           

            //            {
            //                int[][] nums = new int[3][];

            //                nums[0] = new int[] { 4, 6 };
            //                nums[1] = new int[] { 1, 2, 3 };
            //                nums[2] = new int[] { 9, 8, 7, 6 };

            //                for (int i = 0; i < nums.Length; i++)
            //                {
            //                    for (int j = 0; j < nums[i].Length; j++)
            //                    {
            //                        Console.Write(nums[i][j] + " ");
            //                    }
            //                    Console.WriteLine();
            //                }
            //            }
            //        }
            //    }
            //}


            {
                int[][] marks = new int[3][];

                marks[0] = new int[] { 80, 75, 90 };
                marks[1] = new int[] { 65, 70 };
                marks[2] = new int[] { 88, 92, 76, 81 };

                for (int i = 0; i < marks.Length; i++)
                {
                    Console.WriteLine("Student " + (i + 1));

                    for (int j = 0; j < marks[i].Length; j++)
                    {
                        Console.WriteLine(marks[i][j]);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}