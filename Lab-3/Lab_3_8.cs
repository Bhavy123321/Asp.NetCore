using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_Sem_5
{
    public class OddNumberException : Exception
    {
        public OddNumberException() : base("Number must be even!") { }
        public OddNumberException(string message) : base(message) { }
        public OddNumberException(string message, Exception innerException) : base(message, innerException) { }
    }

    internal class Lab_3_8
    {
        public void Exp8()
        {
            Console.WriteLine("=== Even Number Validator ===\n");

            try
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int number))
                {
                    throw new FormatException("Invalid input! Please enter a valid integer.");
                }

                if (number % 2 != 0)
                {
                    throw new OddNumberException($"Error: {number} is not an even number!");
                }

                Console.WriteLine($"Success! {number} is an even number.");
                Console.WriteLine($"Half of {number} is: {number / 2}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Input Error: {ex.Message}");
            }
            catch (OddNumberException ex)
            {
                Console.WriteLine($"Validation Error: {ex.Message}");
                Console.WriteLine("Please enter an even number (divisible by 2).");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }

            Console.WriteLine("\n=== Program Complete ===");
        }
    }
}
