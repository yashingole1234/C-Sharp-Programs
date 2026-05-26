//using System;

//namespace ConsoleApp1
//{
//    class Fan
//    {
//        // Properties
//        string Brand;
//        string Color;
//        int Speed;
//        int Price;

//        // Fan ON
//        public void On()
//        {
//            Console.WriteLine("Fan is ON");
//        }

//        // Fan OFF
//        public void Off()
//        {
//            Console.WriteLine("Fan is OFF");
//        }

//        // Input Method
//        public void FanDetails()
//        {
//            Console.WriteLine("Enter Fan Brand:");
//            Brand = Console.ReadLine();

//            Console.WriteLine("Enter Fan Color:");
//            Color = Console.ReadLine();

//            Console.WriteLine("Enter Fan Speed:");
//            Speed = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Enter Fan Price:");
//            Price = Convert.ToInt32(Console.ReadLine());
//        }

//        public static void Main(string[] args)
//        {
//            Fan fan1 = new Fan();

//            fan1.FanDetails();

//            Console.WriteLine("\nFan Details");

//            Console.WriteLine("Brand: " + fan1.Brand);
//            Console.WriteLine("Color: " + fan1.Color);
//            Console.WriteLine("Speed: " + fan1.Speed);
//            Console.WriteLine("Price: " + fan1.Price);

//            Console.WriteLine("\nEnter 1 for ON and 0 for OFF:");
//            int choice = Convert.ToInt32(Console.ReadLine());

//            if (choice == 1)
//            {
//                fan1.On();
//            }
//            else
//            {
//                fan1.Off();
//            }
//        }
//    }
//}