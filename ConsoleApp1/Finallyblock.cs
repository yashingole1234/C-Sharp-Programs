using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FinallyBlocck
{
   static  string s;
    public static void Main(string[] args)
    {
        s = null;
        try
        {
            int length = s.Length; // This will throw NullReferenceException
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine("String is Null");
        }
        finally
        {
            Console.WriteLine("This block will always be executed!!");
        }
    }
}