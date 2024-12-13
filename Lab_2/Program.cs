using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Candidate c = new Candidate();
            //c.GetCandidateDetails();
            //c.DisplayCandidateDetails();

            //Staff s = new Staff();
            //for (int i = 0; i < 5; i++)
            //{
            //    s.Get_Staff_Detail();
            //    s.Display_Staff_Name_and_Salary();
            //}

            //Bank_Account b = new Bank_Account();
            //b.GetAccountDetails();
            //b.DisplayAccountDetails();

            //Student s = new Student();
            //s.DisplayStudentDetails();

            //Rectangle r = new Rectangle();

            //Account_Details account = new Account_Details();
            //account.GetDetails();
            //Interest interest = new Interest();
            //interest.AccountHolder_Name = account.AccountHolder_Name;
            //interest.Account_No = account.Account_No;
            //interest.Balance = account.Balance;
            //interest.Calcute_Interest();
            //interest.DisplayDetail();

            //Salary sal= new Salary();
            //sal.CalculateSalary();

            //Distance dis = new Distance();
            //dis.add_distance();

            //Table table = new Table();
            //table.Display_Detail();

            Employee emp = new Employee();
            emp.basic_sal();
            Emp_sal Sal = new Emp_sal();
            Sal.Gross_sal();
            Sal.Disp_sal();
        }
    }
}