using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
             int shape_choice;
            Console.WriteLine("Please choose the shape");
            Console.WriteLine("1.Circle\n2.Triangle\n3.Square\n4.Rectangle");
            shape_choice = int.Parse(Console.ReadLine());
            Console.WriteLine("_________________________________________________________\n\n");

            switch (shape_choice)
            {
                case 1:
                    Circle circle = new Circle();
                    break;

                case 2:
                    Triangle triangle = new Triangle();
                    break;

                case 3:
                    Square square = new Square();
                    break;

                case 4:
                    Rectangle rectangle = new Rectangle();
                    break;

                default:
                    Console.WriteLine("Please enter a valid choice");
                    break;

            }
            Console.ReadLine();

        }
    }
}
