using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fibonacci
    
         
        {
        public static void Show()
        {
                int n, a = 0, b = 1, c;

                Console.WriteLine("Enter Number of Terms:");
                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Fibonacci Series:");

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(a);

                    c = a + b;
                    a = b;
                    b = c;
                }
            }
        }
    }


