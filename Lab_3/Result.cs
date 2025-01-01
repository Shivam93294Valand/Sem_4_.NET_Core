using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Result : Calculate
    {
        public void Addition()
        {
            Console.Write("Enter number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " = " + (num1 + num2));
        }

        public void Subtraction()
        {
            Console.Write("Enter number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The subtraction of " + num1 + " and " + num2 + " = " + (num1 - num2));
        }
    }
}
