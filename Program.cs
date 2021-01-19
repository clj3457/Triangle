using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1, side2, side3;

            string input;

            do
            {
                // get user input on lengths of all three sides of a triangle and validate
                Console.Write("Please enter length of first side of triangle: ");
                while (!double.TryParse(Console.ReadLine(), out side1))
                {
                    Console.WriteLine("Invalid format, please input again!");
                }

                Console.Write("Please enter length of second side of triangle: ");
                while (!double.TryParse(Console.ReadLine(), out side2))
                {
                    Console.WriteLine("Invalid format, please input again!");
                }

                Console.Write("Please enter length of third side of triangle: ");
                while (!double.TryParse(Console.ReadLine(), out side3))
                {
                    Console.WriteLine("Invalid format, please input again!");
                }

                // determine if this generates a valid triangle and classify which type of triangle this is
                Triangle triangle = new Triangle(side1, side2, side3);
                Console.WriteLine("Triangle is " + (triangle.IsTriangle()?"valid":"invalid") + " and is " + triangle.Classify());
                Console.WriteLine("\nEnter 'q' to quit or any other key to continue: ");
                input = Console.ReadLine();
            }
            while (!input.Equals("q"));
        }
    }
}
