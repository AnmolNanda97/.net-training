using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{

    class Circle
    {
        public Circle()
        {
            double radius;
            Console.WriteLine("Enter the radius of the Circle");
            Console.Write("Radius:");
            radius = Convert.ToDouble(Console.ReadLine());
            double c = 3.14 * radius * radius;
            Console.WriteLine("The Area of your Circle is {0}", c);
        }
    }


    class Triangle
    {
        public Triangle()
        {
            double height;
            double width;
            Console.WriteLine("Enter the Height and Width of the Triangle");
            Console.Write("Height:");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Width:");
            width = Convert.ToDouble(Console.ReadLine());
            double t = 0.5 * height * width; ;
            Console.WriteLine("The Area of your Triangle is {0}", t);
        }
    }

    class Square
    {
        public Square()
        {
            double side;
            Console.WriteLine("Enter the side of the Square");
            Console.Write("Side:");
            side = Convert.ToDouble(Console.ReadLine());
            double s = side * side;
            Console.WriteLine("The Area of your Square is {0}", s);

        }
    }

    class Rectangle
    {
        public Rectangle()
        {
            double length;
            double breadth;
            Console.WriteLine("Enter the Length and Breadth of the Rectangle");
            Console.Write("Length:");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Breadth:");
            breadth = Convert.ToDouble(Console.ReadLine());
            double r = length * breadth;
            Console.WriteLine("The Area of your Rectangle is {0}", r);

        }
    }
}




            
        


       

       
      

        