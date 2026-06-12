//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class Collection_List
//{
//    public void nongeneric_c()
//    {
//        Console.WriteLine("Non Generic Collection of IList:ArrayList");
//        ArrayList employees = new ArrayList();
//        employees.Add("Pralhad");
//        employees.Add("5000");
//        employees.Add("8.2");
//        employees.Add("Pralhad");
//        Console.WriteLine("ArrayList: ");

//        employees.Insert(1, true);
//        employees.Remove("8.2");
//        employees.LastIndexOf("Pralhad");
//        Console.WriteLine("Last Index of:" + employees.LastIndexOf("Pralhad"));
//        Console.WriteLine("Contains:"+employees.Contains(false));
       
//        for (int i = 0; i < employees.Count; i++) 
//        {
//            Console.WriteLine(employees[i]);
//        }
//        Console.WriteLine("Index of:" + employees.IndexOf("Pralhad"));
        
//        employees.Clear();
//    }
//    public static void Main()
//    {
//        Collection_List c = new Collection_List();
//        c.nongeneric_c();
//    }
//}