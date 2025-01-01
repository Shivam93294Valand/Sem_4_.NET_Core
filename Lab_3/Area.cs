using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Area : Shape
    {
        public void Circle()
        {
            Console.Write("Enter radious of circle = ");
            double radious = Convert.ToDouble(Console.ReadLine());
            
            double area = Math.PI * radious * radious;
            Console.WriteLine("The area of Circle = " + area);
        }

        public void Triangle() 
        {
            Console.Write("Enter height of triangle = ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter base of tringle = ");
            double Base = Convert.ToDouble(Console.ReadLine());
             
            double area = 0.5 * height * Base;
            Console.WriteLine("The area of tringle = " + area);
        }

        public void Square()
        {
            Console.Write("Enter length of square = ");
            double length = Convert.ToDouble(Console.ReadLine());

            double area = length * length;
            Console.WriteLine("The area of square = " + area);
        }
    }
}