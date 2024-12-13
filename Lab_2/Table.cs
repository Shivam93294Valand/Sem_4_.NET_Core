using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Table : Furniture
    {
        public double height;
        public double surface_area;
        public Table() 
        {
            Console.Write("Enter Height of the table : ");  
            height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter area of surface :");
            surface_area = Convert.ToDouble(Console.ReadLine());
        }

        public void Display_Detail()
        {
            Console.WriteLine("\nFurniture Details:");
            Console.WriteLine("The material of product = " + material);
            Console.WriteLine("The price of material = " +price);
            Console.WriteLine("The height of table = " + height);
            Console.WriteLine("The area of surface = " + surface_area);
        }
    }
}