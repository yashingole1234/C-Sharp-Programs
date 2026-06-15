//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class companyinfo
//{
//    public static void Main(string[] args)
//    {
//        companyinfo companyinfo = new companyinfo();
//        companyinfo.details();
//    }
//    public void details()
//    {
//        Console.WriteLine("Company.Information");

//        Dictionary<Int32, String> c = new Dictionary<Int32, String>();
//        c.Add(101, "TCS");
//        c.Add(202, "Capgemini");
//        c.Add(303, "infosys");
//        c.Add(404, "Deloite");
//        c.Add(505, "Yash Technologies");
//        c.Add(505, "Patil Technology");
//        Console.WriteLine("Contains key:" + c.ContainsKey(303));
//        Console.WriteLine("Contains Value:" + c.ContainsValue("Carvita"));

//        Console.WriteLine("Company information in key value pair");
//        foreach (KeyValuePair<Int32, String> info in c)
//        {
//            Console.WriteLine(info);
            
//        }

//        Console.WriteLine("-------------------------------------------");
//        Console.WriteLine("only keys values");
//        foreach (Int32 k in c.Keys) 
//        {
//            Console.WriteLine(k);
//            Thread.Sleep(1000);
//        }
//        Console.WriteLine("-------------------------------------------");
//        Console.WriteLine("only values");
//        foreach (String n in c.Values) 
//        {
//            Console.WriteLine(n);
//            Thread.Sleep(1000);

//        }
//        Console.WriteLine("Object At Key 202 is:" + c[202]);
//    }
//}