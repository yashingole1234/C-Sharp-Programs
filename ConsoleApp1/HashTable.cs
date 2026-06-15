//using System;
//using System.Collections;

//class Program
//{
//    static bool MyContains(Hashtable ht, object key)
//    {
//        foreach (DictionaryEntry item in ht)
//        {
//            if (item.Key.Equals(key))
//                return true;
//        }
//        return false;
//    }

//    static void Main()
//    {
//        Hashtable ht = new Hashtable();

//        ht.Add(101, "Yash");
//        ht.Add(102, "Pralad");
//        ht.Add(103, "Rushi");

//        Console.WriteLine(MyContains(ht, 102)); // True
//        Console.WriteLine(MyContains(ht, 105)); // False
//    }
//}