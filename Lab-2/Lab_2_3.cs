using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ASP.Net_Sem_5
{
    internal class Bank_Account
    {
        long Account_No;
        string Email;
        string User_Name;
        string Account_Type;
        int Account_Balance;

        public void GetAccountDetails()
        {
            Console.WriteLine("Enter Your Account Number Here: ");
            Account_No = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Your Email Here: ");
            Email = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Your User Name Here: ");
            User_Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Your Account Type Here: ");
            Account_Type = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Your Account Balance Here: ");
            Account_Balance = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account Number: " + Account_No);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("User Name: " + User_Name);
            Console.WriteLine("Account Type: " + Account_Type);
            Console.WriteLine("Account Balance: " + Account_Balance);
        }
    }

}
