using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   interface Payment
   {
      void Pay();
   }

   class GooglePay : Payment
   {
      public void Pay()
      {
        Console.WriteLine("Payment Done using Google Pay");
      }
   }

   class InterfaceAbstraction
{
      static void Main()
      {
        GooglePay g = new GooglePay();
        g.Pay();
      }
   }
