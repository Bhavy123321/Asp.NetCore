using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_Sem_5
{
    internal class Lab_3_2
    {
        public void Exp2()
        {
            try
            {
                int[] numbers = new int[5];
                Console.WriteLine("Enter 5 numbers:");
                
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                
                Console.WriteLine("\nNumbers entered:");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Number {i + 1}: {numbers[i]}");
                }
                
                Console.WriteLine("\nTrying to access index 10 (which is out of range):");
                int value = numbers[10];
                Console.WriteLine($"Value at index 10: {value}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: Attempted to access an index that is out of range.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Please enter a valid integer.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            
            Console.WriteLine("\nProgram continues after exception handling.");
        }
    }
}
