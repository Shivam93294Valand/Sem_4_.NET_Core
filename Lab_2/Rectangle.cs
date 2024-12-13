using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    //5.Write a program to calculate area of a Rectangle using constructor.
    internal class Rectangle
    {
        double length;
        double width;

        public Rectangle()
        {
            Console.Write("Enter a length of Rectangle: ");
            length = double.Parse(Console.ReadLine());
            this.length = length;
            Console.Write("Enter a width of Rectangle: ");
            width = double.Parse(Console.ReadLine());
            this.width = width;

            Console.WriteLine("The Area of Rectangle = " + (length * width));
        }
    }
}