//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System;

//namespace ConsoleApp1
//{
//        class Program

//    //{

//        //        public static void CheckDuplicate(int[] arr)
//        //        {
//        //            bool found = false;

//        //            for (int i = 0; i < arr.Length; i++)
//        //            {
//        //                for (int j = i + 1; j < arr.Length; j++)
//        //                {
//        //                    if (arr[i] == arr[j])
//        //                    {
//        //                        Console.WriteLine("Duplicate number found: " + arr[i]);
//        //                        found = true;
//        //                    }
//        //                }
//        //            }

//        //            if (!found)
//        //            {
//        //                Console.WriteLine("No duplicate numbers found.");
//        //            }
//        //        }

//        //        static void Main(string[] args)
//        //        {
//        //            int[] arr = new int[5];

//        //            Console.WriteLine("Enter 5 array elements:");

//        //            for (int i = 0; i < arr.Length; i++)
//        //            {
//        //                arr[i] = Convert.ToInt32(Console.ReadLine());
//        //            }


//        //            CheckDuplicate(arr);
//        //        }
//        //    }
//        //}


//        // 2. Non-static method for Fibonacci series


//        //                public void Fibonacci(int n)
//        //        {
//        //            int a = 0, b = 1, c;

//        //            Console.WriteLine("Fibonacci Series:");

//        //            for (int i = 1; i <= n; i++)
//        //            {
//        //                Console.Write(a + " ");

//        //                c = a + b;
//        //                a = b;
//        //                b = c;
//        //            }

//        //            Console.WriteLine();
//        //        }


//        //        public static void Main(string[] args)
//        //        {
//        //            Program obj = new Program();

//        //            Console.Write("Enter number of terms: ");
//        //            int n = Convert.ToInt32(Console.ReadLine());

//        //            obj.Fibonacci(n);
//        //        }
//        //    }
//        //}





////        // Parameterized Method
////        public static void Average(int n1, int n2, int n3, int n4)
////        {
////            double avg = (n1 + n2 + n3 + n4) / 4.0;

////            Console.WriteLine("Average = " + avg);
////        }

////        static void Main(string[] args)
////        {
////            Console.WriteLine("Enter 4 numbers:");

////            int a = Convert.ToInt32(Console.ReadLine());
////            int b = Convert.ToInt32(Console.ReadLine());
////            int c = Convert.ToInt32(Console.ReadLine());
////            int d = Convert.ToInt32(Console.ReadLine());

          
////            Average(a, b, c, d);
////        }
////    }
////}

