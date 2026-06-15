//using System;
//using System.Collections;

//class Program
//{
//    static bool MyContains(ArrayList list, object item)
//    {
//        foreach (object element in list)
//        {
//            if (element.Equals(item))
//            {
//                return true;
//            }
//        }
//        return false;
//    }

//    static void Main()
//    {
//        ArrayList arr = new ArrayList();
//        arr.Add(10);
//        arr.Add(20);
//        arr.Add(30);
//        arr.Add(40);

//        int search = 30;

//        if (MyContains(arr, search))
//            Console.WriteLine(search + " is present.");
//        else
//            Console.WriteLine(search + " is not present.");
//    }
//}