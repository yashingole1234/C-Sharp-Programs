//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C_Sharp_Programs
//{
//    internal class BubbleSort
//    {
     

//class Program
//    {
//        static void BubbleSort(int[] arr)
//        {
//            int temp;

//            for (int i = 0; i < arr.Length - 1; i++)
//            {
//                for (int j = 0; j < arr.Length - i - 1; j++)
//                {
//                    if (arr[j] > arr[j + 1])
//                    {
//                        // Swapping
//                        temp = arr[j];
//                        arr[j] = arr[j + 1];
//                        arr[j + 1] = temp;
//                    }
//                }
//            }
//        }

//        static void PrintArray(int[] arr)
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                Console.Write(arr[i] + " ");
//            }

//            Console.WriteLine();
//        }

//        static void Main(string[] args)
//        {
//            int[] arr = { 2, 6, 5, 7, 8 };
//                BubbleSort(arr);
//            Console.WriteLine("Original Array:");
//            PrintArray(arr);

//            BubbleSort(arr);

//            Console.WriteLine("Sorted Array:");
//            PrintArray(arr);
//        }
//    }
//}
//}
