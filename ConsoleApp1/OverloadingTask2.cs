//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C_Sharp_Programs
//{
     
    
//        class Shape
//        {
//            // Square
//            public void Area(int side)
//            {
//                int area = side * side;

//                Console.WriteLine("Area of Square is: " + area);
//            }

//            // Rectangle
//            public void Area(int length, int breadth)
//            {
//                int area = length * breadth;

//                Console.WriteLine("Area of Rectangle is: " + area);
//            }

//            // Triangle
//            public void Area(float b, float h)
//            {
//                float area = 0.5f * b * h;

//                Console.WriteLine("Area of Triangle is: " + area);
//            }

//            // Circle
//            public void Area(double radius)
//            {
//                double area = 3.14 * radius * radius;

//                Console.WriteLine("Area of Circle is: " + area);
//            }

//            static void Main(string[] args)
//            {
//                Shape s = new Shape();

//                // Square Input
//                Console.WriteLine("Enter Side of Square:");
//                int side = Convert.ToInt32(Console.ReadLine());
//                s.Area(side);

//                // Rectangle Input
//                Console.WriteLine("\nEnter Length of Rectangle:");
//                int length = Convert.ToInt32(Console.ReadLine());

//                Console.WriteLine("Enter Breadth of Rectangle:");
//                int breadth = Convert.ToInt32(Console.ReadLine());

//                s.Area(length, breadth);

//                // Triangle Input
//                Console.WriteLine("\nEnter Base of Triangle:");
//                float b = Convert.ToSingle(Console.ReadLine());

//                Console.WriteLine("Enter Height of Triangle:");
//                float h = Convert.ToSingle(Console.ReadLine());

//                s.Area(b, h);

//                // Circle Input
//                Console.WriteLine("\nEnter Radius of Circle:");
//                double radius = Convert.ToDouble(Console.ReadLine());

//                s.Area(radius);
//            }
//        }
//    }


