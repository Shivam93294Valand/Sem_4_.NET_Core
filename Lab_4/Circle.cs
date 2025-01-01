using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Circle : Find_Area
    {
        public override void Area()
        {
            Console.Write("Enter radious of circle :");
            double radious = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Area of Square = " + (Math.PI * radious * radious));
        }
    }
}
