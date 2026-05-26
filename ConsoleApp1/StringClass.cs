using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StringClass
    {
        public static void Show()
        {

            {
                string str1 = "Manoj";

                Console.WriteLine("before replacement:" + str1);

                str1 = str1.Replace('a', 'o');

                Console.WriteLine("replace is:" + str1);

                Console.WriteLine("after replacement:" + str1);
            }
        }
        //string class
        // string city = new string("Yavatmal");
        // Console.WriteLine("before replacement:" + city);
        // Console.WriteLine("Upper case:" + city.ToUpper());
        //Console.WriteLine("Lower case:" + city.ToLower());
        // Console.WriteLine("after replacement:" + city);
        // Console.WriteLine("---------------------------");



        //string class=string builder
        // StringBuilder clg = new StringBuilder("jaju");  
        //Console.WriteLine("before append:" + clg);
        // Console.WriteLine("append is:" + clg.Append(" college"));
        // Console.WriteLine("after append:" + clg);

    }
}

