using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    //6. Write a program for implementing single inheritance which creates one
    //class Account_Details for getting account information and another class
    //Interest for calculating and displaying total interest from the data inserted
    //from account details.
    internal class Account_Details
    {
        public string AccountHolder_Name;
        public int Account_No;
        public int Balance;

        public void GetDetails()
        {
            Console.Write("Enter Name of Account Holder: ");
            AccountHolder_Name = Console.ReadLine();
            Console.Write("Enter Account Number: ");
            Account_No = int.Parse(Console.ReadLine());
            Console.Write("Enter Balance of Account Holder: ");
            Balance = Convert.ToInt32(Console.ReadLine());
        }
    }
}