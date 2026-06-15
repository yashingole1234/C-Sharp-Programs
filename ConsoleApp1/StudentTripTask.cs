//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.AccessControl;
//using System.Text;
//using System.Threading.Tasks;


//class Task
//{
//    public static void Main(string[] args)
//    {
//        Task t = new Task();
//        implement_contains();
//        t.Tripinfo();
//        t.implement_indexof();
//    }

//    public void Tripinfo()
//    {
//        Dictionary<Int32, String> students = new Dictionary<Int32, String>();
//        students.Add(10, "Tina");
//        students.Add(20, "Yash");
//        students.Add(30, "Aditi");
//        students.Add(40, "Sam");

//        if (students.ContainsKey(30))
//        {
//            students.Remove(30);

//        }
//        Console.WriteLine("Final list of students:");

//        foreach (var st in students)
//        {
//            Console.WriteLine(st);
//        }
//    }
//    public void implement_indexof()
//    {
//        List<string> teachers = new List<string>();
//        teachers.Add("Pooja");
//        teachers.Add("Pratiksha");
//        teachers.Add("Anushka");
//        teachers.Add("Sakshi");

//        for (int i = 0; i < teachers.Count; i++) 
//        {
//            if (teachers[i] == "Pratiksha")
//            {
//                Console.WriteLine("index of Pratiksha is:" + i);
//            }
//        }
//    }
//    public static void implement_contains()
//    {
//        Hashtable hs = new Hashtable();
//        hs.Add(1,'U');
//        hs.Add(2, "Seema");
//        hs.Add(3, 6.8);
//        hs.Add(4, 'p');

//        Object ch = 'p';
//        int count = 0;

//        for (int i = 0; i < hs.Count; i++)
//        {
//            if (hs[i + 1].Equals(ch))
//            {
//                count++;
//            }
        
//    }
//        if (count == 0)
//        {
//            Console.WriteLine("Character 'p' is not present");
//        }
//        else
//        {
//            Console.WriteLine("Character 'p' is present");
//        }
//    }
//}
