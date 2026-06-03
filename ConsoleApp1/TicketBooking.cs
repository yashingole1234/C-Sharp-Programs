//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//// Custom Exception Class
//class SeatNotAvailableException : Exception
//{
//    public SeatNotAvailableException(string message) : base(message) // Constructor to pass custom error message to base Exception class
//    {
//    }
//}

//class TicketBooking
//{
//    static void Main()
//    {
//        Console.Write("Enter Available Seats: ");//user input for available seats
//        int seats = Convert.ToInt32(Console.ReadLine());

//        if (seats > 0)
//        {
//            Console.WriteLine("Ticket Booked Successfully"); //if seats are available, print success message
//        }
//        else
//        {
//            throw new SeatNotAvailableException("No Seats Available");//if no seats are available, throw custom exception with message
//        }
//    }
//}