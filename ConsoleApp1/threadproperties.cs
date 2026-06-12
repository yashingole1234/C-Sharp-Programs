//using System;
//using System.Threading;

//class ThreadPropertiesDemo
//{
//    static void Work()
//    {
//        Console.WriteLine("Thread is Running...");
//        Thread.Sleep(3000);
//    }

//    static void Main()
//    {
//        Thread t = new Thread(Work);

//        // Name Property
//        t.Name = "MyThread";

//        // Priority Property
//        t.Priority = ThreadPriority.AboveNormal;

//        // Background Property
//        t.IsBackground = false;

//        Console.WriteLine("Thread Name: " + t.Name);
//        Console.WriteLine("Thread Priority: " + t.Priority);
//        Console.WriteLine("Is Background: " + t.IsBackground);
//        Console.WriteLine("Managed Thread ID: " + t.ManagedThreadId);
//        Console.WriteLine("Thread State Before Start: " + t.ThreadState);

//        t.Start();

//        Console.WriteLine("Is Alive: " + t.IsAlive);
//        Console.WriteLine("Thread State After Start: " + t.ThreadState);

//        t.Join(); // Wait for thread completion

//        Console.WriteLine("Thread State After Completion: " + t.ThreadState);
//        Console.WriteLine("Is Alive After Completion: " + t.IsAlive);
//    }
//}