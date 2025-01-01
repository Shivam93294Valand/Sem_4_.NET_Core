using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Rectengle : Find_Area
    {
        public override void Area()
        {
            Console.Write("Enter length of rectangle :");
            double len = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width of rectangle :");
            double wid = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Area of rectangle = " + (len * wid));
        }
    }
}
