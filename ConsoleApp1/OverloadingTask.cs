//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using System;

//namespace ConsoleApp1
//{
//    class Shape
//    {
//        // Square
//        public void Area(int side)
//        {
//            int area = side * side;

//            Console.WriteLine("Area of Square is: " + area);
//        }

//        // Rectangle
//        public void Area(int length, int breadth)
//        {
//            int area = length * breadth;

//            Console.WriteLine("Area of Rectangle is: " + area);
//        }

//        // Triangle
//        public void Area(float b, float h)
//        {
//            float area = 0.5f * b * h;

//            Console.WriteLine("Area of Triangle is: " + area);
//        }

//        // Circle
//        public void Area(double radius)
//        {
//            double area = 3.14 * radius * radius;

//            Console.WriteLine("Area of Circle is: " + area);
//        }

//        static void Main(string[] args)
//        {
//            Shape s = new Shape();

//            s.Area(5);          // Square
//            s.Area(10, 5);      // Rectangle
//            s.Area(10f, 5f);    // Triangle
//            s.Area(7.0);        // Circle
//        }
//    }
//}
