using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_Sem_5
{
    public interface Calculate1
    {
        int Addition(int a, int b);
        int Subtraction(int a, int b);
    }

    public class Result : Calculate1
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }
    }

    public  class Lab_3_4
    {
        public void Exp4()
        {
            Result result = new Result();

            int addResult = result.Addition(20, 10);
            Console.WriteLine($"Addition of 20 and 10: {addResult}");

            int subResult = result.Subtraction(20, 10);
            Console.WriteLine($"Subtraction of 20 and 10: {subResult}");

            Console.WriteLine("\nEnter two numbers for calculation:");
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int userAddResult = result.Addition(num1, num2);
            int userSubResult = result.Subtraction(num1, num2);

            Console.WriteLine($"\nResults:");
            Console.WriteLine($"Addition of {num1} and {num2}: {userAddResult}");
            Console.WriteLine($"Subtraction of {num1} and {num2}: {userSubResult}");
        }
    }
}

