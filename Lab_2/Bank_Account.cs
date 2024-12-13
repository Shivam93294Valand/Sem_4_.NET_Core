using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    //3. Write a pogram to Create a class Bank_Account with Account_No, Email,
    //User_Name, Account_Type and Account_Balance as data members.Also
    //create a Member function GetAccountDetails() & DisplayAccountDetails().

    internal class Bank_Account
    {
        int Account_No;
        string Email;
        string User_Name;
        string Account_Type;
        int Account_Balance;

        public void GetAccountDetails()
        {
            Console.Write("\nEnter a Account Number: ");
            this.Account_No = int.Parse(Console.ReadLine());
            Console.Write("Enter a Email: ");
            this.Email = Console.ReadLine();
            Console.Write("Enter a User Name: ");
            this.User_Name = Console.ReadLine();
            Console.Write("Enter a Account Type: ");
            this.Account_Type = Console.ReadLine();
            Console.Write("Enter a Account Balance: ");
            this.Account_Balance = int.Parse(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("\nBanck Account Details");
            Console.WriteLine("Account Number = " + Account_No);
            Console.WriteLine("Email = " + Email);  
            Console.WriteLine("User Name = " + User_Name);
            Console.WriteLine("Account Type = " + Account_Type);
            Console.WriteLine("Account Balance = " + Account_Balance);
        }
    }
}