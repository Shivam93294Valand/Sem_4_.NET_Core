using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Write a program to Create a divide by zero exception and handle it.
            //Console.Write("Enter number 1 :");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter number 2 :");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //try
            //{
            //    int num3 = num1 / num2;
            //    Console.WriteLine(num1 + " / " + num2 + " = " + num3);
            //}
            //catch (DivideByZeroException ex)
            //{ 
            //    Console.WriteLine(ex.Message);
            //}

            //2.Write a program that reads 5 numbers from user.Demonstrate concept of
            //IndexOutOfRange Exception.
            //int[] arr = new int[5];
            //try
            //{
            //    for (int i = 0; i <= arr.Length; i++)
            //    {
            //        Console.WriteLine("Enter number : ");
            //        arr[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //catch (Exception ex)
            //{ 
            //    Console.WriteLine(ex.Message);
            //}

            //3.Write a program to create an abstract class Sum having abstract methods
            //SumOfTwo(int a, int b) and SumOfThree(int a, int b, int c). Create another
            //class Calculate which extends the abstract class and implements the
            //abstract methods.
            //Calculate_Sum sum = new Calculate_Sum();
            //int ans1 = sum.SumOfTwo(5, 9);
            //int ans2 = sum.SumOfThree(1,2,3);
            //Console.WriteLine("Ans1 = " + ans1 + "\nAns2 = " + ans2);

            //4.Write a program to create interface Calculate. In this interface we have two
            //member functions Addition() and Subtraction(). Implements this interface
            //in another class named Result.
            //Result res = new Result();
            //res.Addition();
            //res.Subtraction();

            //5.Write program showing use of common methods of String class.
            //Console.Write("Enter a string : ");
            //String s1 = Console.ReadLine();
            //Console.Write("Enter a string : ");
            //String s2 = Console.ReadLine();
            //Console.WriteLine(s1.Equals(s2));
            //Console.WriteLine(s1.ToUpper());
            //Console.WriteLine(s2.ToLower());
            //Console.WriteLine(s1.Trim());

            //6.Write a program to Replace lower case characters to upper case and Vice-versa.
            //Console.Write("Enter a string : ");
            //String s1 = Console.ReadLine();
            //char[] characters = s1.ToCharArray();
            //foreach (char ch in characters)
            //{
            //    if (ch >= 'A' && ch <= 'Z')
            //    {
            //        Console.Write(ch.ToString().ToLower());
            //    }
            //    else
            //    { 
            //        Console.Write(ch.ToString().ToUpper());
            //    }
            //}

            //7.Write a program to create interface named Shape.In this interface, we
            //have three methods Circle(), Triangle() and Square() which calculates area
            //of Circle, Triangle and Square respectively.Implement Shape interface.
            //Area ar = new Area();
            //ar.Circle();
            //ar.Triangle();
            //ar.Square();

            //8.Write a program to accept a number from the user and throw an exception
            //if the number is not an even number.
            //try
            //{
            //    Console.Write("Enter a number = ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num % 2 != 0)
            //    {
            //        throw new NotEvenNumberException("The number is not even.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number is even.");
            //    }
            //}
            //catch (NotEvenNumberException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Please enter a valid integer.");
            //}

            //9.Write a program to find the longest word in a string.
            //Console.Write("Enter a string: ");
            //string str = Console.ReadLine();
            //string[] strs = str.Split(' ');
            //int str_len = 0;
            //string max_word = strs[0];
            //for (int i = 1; i < strs.Length; i++)
            //{
            //    int str_len2 = strs[i].Length;
            //    if (str_len2 > str_len)
            //    {
            //        str_len = str_len2;
            //        max_word = strs[i];
            //    }
            //}
            //Console.WriteLine("The longest word in given string = " + max_word);

            //10.Write a program to change the case of entered character.
            Console.Write("Enter a charactor : ");
            Char ch = Convert.ToChar(Console.ReadLine());
            if (ch >= 'A' && ch <= 'Z')
            {
                Console.Write(ch.ToString().ToLower());
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                Console.Write(ch.ToString().ToUpper());
            }
            else
            {
                Console.Write("Please Enter a charactor");
            }
        }
    }
}