//using System;
//using System.Collections.Generic;

//class Task
//{
//    public void Tripinfo()
//    {
//        Dictionary<int, string> students = new Dictionary<int, string>();

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
//                Console.WriteLine("Index of Pratiksha is: " + i);
//            }
//        }
//    }
//}

//class usingstackstudenttriptask
//{
//    public static void Main(string[] args)
//    {
//        Task t = new Task();

//        implement_stack();

//        Console.WriteLine("--------------------------");

//        t.Tripinfo();

//        Console.WriteLine("--------------------------");

//        t.implement_indexof();
//    }

//    public static void implement_stack()
//    {
//        Stack<char> st = new Stack<char>();

//        st.Push('U');
//        st.Push('S');
//        st.Push('P');
//        st.Push('p');

//        char ch = 'p';
//        int count = 0;

//        foreach (char item in st)
//        {
//            if (item == ch)
//            {
//                count++;
//            }
//        }

//        if (count == 0)
//        {
//            Console.WriteLine("Character 'p' is not present");
//        }
//        else
//        {
//            Console.WriteLine("Character 'p' is present");
//        }

//        Console.WriteLine("Stack Elements:");

//        foreach (char item in st)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}