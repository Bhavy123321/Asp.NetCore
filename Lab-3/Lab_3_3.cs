using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_Sem_5
{
    public abstract class Sum
    {
        public abstract int SumOfTwo(int a, int b);
        public abstract int SumOfThree(int a, int b, int c);
    }

    public class Calculate : Sum
    {
        public override int SumOfTwo(int a, int b)
        {
            return a + b;
        }

        public override int SumOfThree(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    internal class Lab_3_3
    {
        public void Exp3()
        {
            Calculate calc = new Calculate();

            int result1 = calc.SumOfTwo(10, 20);
            Console.WriteLine($"Sum of two numbers : {result1}");

            int result2 = calc.SumOfThree(10, 20, 30);
            Console.WriteLine($"Sum of three numbers : {result2}");

            Console.WriteLine("\nEnter two numbers to add:");
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            int userResult1 = calc.SumOfTwo(num1, num2);
            Console.WriteLine($"Sum of {num1} and {num2}: {userResult1}");

            Console.WriteLine("\nEnter three numbers to add:");
            Console.Write("Enter first number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            
            int userResult2 = calc.SumOfThree(num3, num4, num5);
            Console.WriteLine($"Sum of {num3}, {num4}, and {num5}: {userResult2}");
        }
    }
}
