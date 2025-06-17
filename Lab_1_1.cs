using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_Sem_5
{
    public class Lab_1_1
    {
        public void demo()
        {
            Console.WriteLine("Enter Your Name Here");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter Your Address Here");
            string Address = Console.ReadLine();

            Console.WriteLine("Enter Your City Here");
            string City = Console.ReadLine();

            Console.WriteLine("Enter Your Contact Here");
            string Contact = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Your Personal Information");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Address : " + Address);
            Console.WriteLine("City : " + City);
            Console.WriteLine("Contact : " + Contact);
        }
    }
}
