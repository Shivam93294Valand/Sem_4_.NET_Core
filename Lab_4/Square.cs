using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Square : Find_Area
    {
        public override void Area()
        {
            Console.Write("Enter length of square :");
            double len = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Area of Square = " + (len * len));
        }
    }
}
