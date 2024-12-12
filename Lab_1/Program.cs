using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Write a program to print your name, address, contact number & city.
            //Console.WriteLine("Name: Shivam Valand");
            //Console.WriteLine("Address: Hadala");
            //Console.WriteLine("Contact Number: 123456789");
            //Console.WriteLine("City: Rajkot");

            //2. Write a program to get two numbers from user and print those two numbers.
            //Console.Write("Enter number 1: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter number 2: ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("number 1: " + num1);
            //Console.WriteLine("number 2: " + num2);

            //3. Write program to prompt a user to input his/her name and country name
            //and then output will be shown as given: Hello <yourname> from country
            //<countryname>
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter your country: ");
            //string country = Console.ReadLine();
            //Console.WriteLine("Hello " + name + " from country " + country);

            //4. Write a program to calculate the size of the area in square-feet based on
            //Specified length and width.
            //Console.Write("Enter length in feet: ");
            //double length = double.Parse(Console.ReadLine());
            //Console.Write("Enter width in feet: ");
            //double width = double.Parse(Console.ReadLine());
            //double area = length * width;
            //Console.WriteLine("Area in square feet: " + area);

            //5. Write a program to calculate area of Square, Rectangle and Circle.
            //for square
            //Console.Write("Enter the side of the square: ");
            //double side = double.Parse(Console.ReadLine());
            //double squareArea = side * side;
            //Console.WriteLine("Area of Square: " + squareArea);
            //for Rectangle
            //Console.Write("Enter the length of the rectangle: ");
            //double length = double.Parse(Console.ReadLine());
            //Console.Write("Enter the width of the rectangle: ");
            //double width = Convert.ToDouble(Console.ReadLine());
            //double rectangleArea = length * width;
            //Console.WriteLine("Area of Rectangle: " + rectangleArea);
            //for Circle
            //Console.Write("Enter the radius of the circle: ");
            //double radius = double.Parse(Console.ReadLine());
            //double circleArea = Math.PI * radius * radius;
            //Console.WriteLine("Area of Circle: " + circleArea);

            //6. Write a program to calculate Celsius to Fahrenheit and vice-versa using function.
            //void Celsius_to_Fahrenheit(double celsius)
            //{
            //    double res = (celsius * 9 / 5) + 32;
            //    Console.WriteLine(celsius + " Celsius = " + res + " Fahrenheit");
            //}
            //void Fahrenheit_to_Celsius(double fahrenheit)
            //{
            //    double res = (fahrenheit - 32) * 5 / 9;
            //    Console.WriteLine(fahrenheit + " Fahrenheit = " + res + " Celsius");
            //}
            //Console.WriteLine("Enter 1 for Celsius to Fahrenheit");
            //Console.WriteLine("Enter 2 for Fahrenheit to Celsius");
            //int num = int.Parse(Console.ReadLine());
            //if (num == 1)
            //{
            //    Console.Write("Enter temperature in Celsius: ");
            //    double celsius = double.Parse(Console.ReadLine());
            //    Celsius_to_Fahrenheit(celsius);
            //}
            //else if (num == 2)
            //{
            //    Console.Write("Enter temperature in Fahrenheit: ");
            //    double fahrenheit = double.Parse(Console.ReadLine());
            //    Fahrenheit_to_Celsius(fahrenheit);
            //}
            //else 
            //{
            //    Console.Write("Please Enter number from 1 or 2: ");
            //}

            //7. Write a program to find out Simple Interest using function. (I = PRN/100)
            //Console.Write("Enter Principal: ");
            //double principal = double.Parse(Console.ReadLine());
            //Console.Write("Enter Rate of Interest: ");
            //double rate = double.Parse(Console.ReadLine());
            //Console.Write("Enter Time period: ");
            //double time = double.Parse(Console.ReadLine());
            //double si = (principal * rate * time) / 100;
            //Console.WriteLine("Simple Interest: " + si);

            //8. Write a program to create a Simple Calculator for two numbers (Addition,
            //Multiplication, Subtraction, Division) [Also using if…else & Switch Case]
            //Console.Write("Enter number 1: ");
            //double num1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter number 2: ");
            //double num2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter 1 for Addition");
            //Console.WriteLine("Enter 2 for Subtraction");
            //Console.WriteLine("Enter 3 for Multiplication");
            //Console.WriteLine("Enter 4 for Division");
            //int opr = int.Parse(Console.ReadLine());
            //if (opr == 1)
            //{
            //    double res = num1 + num2;
            //    Console.WriteLine("The Addition of " + num1 + " and " + num2 + " = " + res);
            //}
            //else if (opr == 2)
            //{
            //    double res = num1 - num2;
            //    Console.WriteLine("The Subtraction of " + num1 + " and " + num2 + " = " + res);
            //}
            //else if (opr == 3)
            //{
            //    double res = num1 * num2;
            //    Console.WriteLine("The Multiplaction of " + num1 + " and " + num2 + " = " + res);
            //}
            //else if (opr == 4)
            //{
            //    double res = num1 / num2;
            //    Console.WriteLine("The Division of " + num1 + " and " + num2 + " = " + res);
            //}
            //else
            //{
            //    Console.WriteLine("Please Enter number between 1 to 4");
            //}

            //9. Write a program to Swapping without using third variable.
            //Console.Write("Enter number 1: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter number 2: ");
            //int num2 = int.Parse(Console.ReadLine());
            //num1 = num1 + num2;
            //num2 = num1 - num2;
            //num1 = num1 - num2;
            //or
            //num1 = num1 ^ num2;
            //num2 = num1 ^ num2;
            //num1 = num1 ^ num2;
            //Console.WriteLine("Number 1 = " + num1 + "\nNumber 2 = " + num2);

            //10.Write a program to find maximum numbers from given 3 numbers using
            //ternary operator.
            //Console.Write("Enter first number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter third number: ");
            //int num3 = int.Parse(Console.ReadLine());
            //int max = (num1 > num2 && num1 > num3) ? num1 : (num2 > num3) ? num2 : num3;
            //Console.WriteLine("The maximum number = " + max);
        }
    }
}