using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_Sem_5

{
    internal class Lab_3_6
    {
        public void Exp6()
        {
            Console.WriteLine("=== Case Conversion Program ===\n");

            Console.WriteLine("Method 1: Using built-in string methods");
            string text1 = "Hello World";
            string text2 = "C# PROGRAMMING";
            string text3 = "MiXeD cAsE";

            Console.WriteLine($"Original: '{text1}'");
            Console.WriteLine($"To Upper: '{text1.ToUpper()}'");
            Console.WriteLine($"To Lower: '{text1.ToLower()}'");
            Console.WriteLine();

            Console.WriteLine($"Original: '{text2}'");
            Console.WriteLine($"To Upper: '{text2.ToUpper()}'");
            Console.WriteLine($"To Lower: '{text2.ToLower()}'");
            Console.WriteLine();

            Console.WriteLine($"Original: '{text3}'");
            Console.WriteLine($"To Upper: '{text3.ToUpper()}'");
            Console.WriteLine($"To Lower: '{text3.ToLower()}'");
            Console.WriteLine();

            Console.WriteLine("Method 2: Custom case swapping (lowercase ↔ uppercase)");

            string[] testStrings = { "Hello World", "C# PROGRAMMING", "MiXeD cAsE", "123 Numbers!", "aBcDeF" };

            foreach (string str in testStrings)
            {
                string swapped = SwapCase(str);
                Console.WriteLine($"Original: '{str}'");
                Console.WriteLine($"Swapped:  '{swapped}'");
                Console.WriteLine();
            }

            Console.WriteLine("Method 3: Interactive case conversion");
            Console.Write("Enter a string to convert: ");
            string userInput = Console.ReadLine();

            if (!string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine($"Original: '{userInput}'");
                Console.WriteLine($"To Upper: '{userInput.ToUpper()}'");
                Console.WriteLine($"To Lower: '{userInput.ToLower()}'");
                Console.WriteLine($"Swapped:  '{SwapCase(userInput)}'");
            }

            Console.WriteLine("\n=== Case Conversion Complete ===");
        }

        static string SwapCase(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLower(chars[i]))
                {
                    chars[i] = char.ToUpper(chars[i]);
                }
                else if (char.IsUpper(chars[i]))
                {
                    chars[i] = char.ToLower(chars[i]);
                }
            }

            return new string(chars);
        }
    }
}
