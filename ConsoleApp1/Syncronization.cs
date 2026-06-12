//using System;
//using System.Runtime.InteropServices;
//using System.Threading;

//class person
//{
//    public static object lock_obj = new object();

//    public static void table()
//    {
//        for (int i = 1; i <= 10; i++)

//        {
//            lock (lock_obj)
//            {
//                Console.WriteLine(Thread.CurrentThread.Name + "->" + 5 * i);
//                //Thread.Sleep(1000);
//            }
//        }
//    }
//    class Syncronization
//    {
//        static void Main()
//        {
//            Thread p = new Thread(person.table);
//            p.Name = "Pralhad";
//            Thread r = new Thread(person.table);
//            r.Name = "Rushi";
//            Thread y = new Thread(person.table);
//            y.Name = "Yash";
//            Thread a = new Thread(person.table);
//            a.Name = "Aditi";
//            p.Start();
//           // p.Join();
//            r.Start();
//            y.Start();
//            a.Start();

//        }
//    }
//}
