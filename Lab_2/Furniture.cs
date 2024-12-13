using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    //9. Create a class Furniture with material, price as data members.Create
    //another class Table with Height, surface_area as data members.Write a
    //program to implement single inheritance.
    internal class Furniture
    {
        public string material;
        public double price;

        public Furniture()
        {
            Console.Write("Enter the name of material: ");
            material = Console.ReadLine();
            Console.Write("Enter prise of material : ");
            price = Convert.ToDouble(Console.ReadLine());
        }
    }
}
