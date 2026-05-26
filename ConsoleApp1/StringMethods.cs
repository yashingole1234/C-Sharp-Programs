using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StringMethods
    {
        public static void Show()
        {
            string str1 = "YASH";
            Console.WriteLine("string is: " + str1);
            Console.WriteLine("uppercase is:" + str1.ToUpper());
            Console.WriteLine("Lowercase is:" + str1.ToLower());
            Console.WriteLine("Length is:" + str1.Length);
            Console.WriteLine("Replace is:" + str1.Replace('A', 'P'));
            Console.WriteLine("Trim is:" + str1.Trim());
            Console.WriteLine("Index of A is:" + str1.IndexOf('Y'));
            Console.WriteLine("Substring is:" + str1.Substring(1, 3));
            char[] alpha = str1.ToArray();
            for (int i = 0; i < alpha.Length; i++)
            {
                Console.WriteLine(alpha[i]);
            }
            Console.WriteLine("Contains is:" + str1.Contains("Y"));
            Console.WriteLine("Original string is:" + str1);
        }
    }
}
