using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Distance
    {
        //8. Write a program to Define a class Distance have data members dist1, dist2,
        //dist3. Initialize the two data members using constructor and store their
        //addition in third data member using function and display addition.

        public double dist1;
        public double dist2;
        public double dist3;

        public Distance() 
        {
            Console.Write("Enter Distance 1: ");
            dist1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Distance 2: ");
            dist2 = Convert.ToDouble(Console.ReadLine());
        }

        public void add_distance ()
        {
            dist3 = dist1 + dist2;
            Console.WriteLine("The total distance = " + dist3);
        }
    }
}
