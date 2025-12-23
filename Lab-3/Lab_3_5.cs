using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_Sem_5
{
    public class Lab_3_5
    {
        public void Exp5()
        {
            Console.WriteLine("=== String Class Methods Demonstration ===\n");

            string text1 = "Hello World";
            string text2 = "  C# Programming  ";
            string text3 = "apple,banana,orange";
            string text4 = "Hello World";

            Console.WriteLine("Original strings:");
            Console.WriteLine($"text1: '{text1}'");
            Console.WriteLine($"text2: '{text2}'");
            Console.WriteLine($"text3: '{text3}'");
            Console.WriteLine($"text4: '{text4}'\n");

            Console.WriteLine("1. Length property:");
            Console.WriteLine($"Length of '{text1}': {text1.Length}");
            Console.WriteLine($"Length of '{text2}': {text2.Length}\n");

            Console.WriteLine("2. ToUpper() and ToLower():");
            Console.WriteLine($"'{text1}' to upper: '{text1.ToUpper()}'");
            Console.WriteLine($"'{text1}' to lower: '{text1.ToLower()}'\n");

            Console.WriteLine("3. Substring():");
            Console.WriteLine($"Substring(0, 5) of '{text1}': '{text1.Substring(0, 5)}'");
            Console.WriteLine($"Substring(6) of '{text1}': '{text1.Substring(6)}'\n");

            Console.WriteLine("4. IndexOf():");
            Console.WriteLine($"Index of 'o' in '{text1}': {text1.IndexOf('o')}");
            Console.WriteLine($"Index of 'World' in '{text1}': {text1.IndexOf("World")}");
            Console.WriteLine($"Index of 'z' in '{text1}': {text1.IndexOf('z')} (not found)\n");

            Console.WriteLine("5. Replace():");
            Console.WriteLine($"Replace 'o' with '0' in '{text1}': '{text1.Replace('o', '0')}'");
            Console.WriteLine($"Replace 'World' with 'C#' in '{text1}': '{text1.Replace("World", "C#")}'\n");

            Console.WriteLine("6. Trim methods:");
            Console.WriteLine($"Trim of '{text2}': '{text2.Trim()}'");
            Console.WriteLine($"TrimStart of '{text2}': '{text2.TrimStart()}'");
            Console.WriteLine($"TrimEnd of '{text2}': '{text2.TrimEnd()}'\n");

            Console.WriteLine("7. Split():");
            string[] fruits = text3.Split(',');
            Console.WriteLine($"Split '{text3}' by ',':");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine($"  [{i}]: '{fruits[i]}'");
            }
            Console.WriteLine();

            Console.WriteLine("8. Contains():");
            Console.WriteLine($"'{text1}' contains 'World': {text1.Contains("World")}");
            Console.WriteLine($"'{text1}' contains 'Python': {text1.Contains("Python")}\n");

            Console.WriteLine("9. StartsWith() and EndsWith():");
            Console.WriteLine($"'{text1}' starts with 'Hello': {text1.StartsWith("Hello")}");
            Console.WriteLine($"'{text1}' starts with 'World': {text1.StartsWith("World")}");
            Console.WriteLine($"'{text1}' ends with 'World': {text1.EndsWith("World")}");
            Console.WriteLine($"'{text1}' ends with 'Hello': {text1.EndsWith("Hello")}\n");

            Console.WriteLine("10. Equals() and comparison:");
            Console.WriteLine($"'{text1}' equals '{text4}': {text1.Equals(text4)}");
            Console.WriteLine($"'{text1}' equals '{text1.ToLower()}': {text1.Equals(text1.ToLower())}");
            Console.WriteLine($"'{text1}' equals '{text1.ToLower()}' (ignore case): {text1.Equals(text1.ToLower(), StringComparison.OrdinalIgnoreCase)}\n");

            Console.WriteLine("11. Insert() and Remove():");
            string inserted = text1.Insert(5, " Beautiful ");
            Console.WriteLine($"Insert ' Beautiful ' at position 5 in '{text1}': '{inserted}'");
            string removed = text1.Remove(5, 6);
            Console.WriteLine($"Remove 6 characters from position 5 in '{text1}': '{removed}'\n");

            Console.WriteLine("12. PadLeft() and PadRight():");
            Console.WriteLine($"PadLeft(15, '') of '{text1}': '{text1.PadLeft(15, '*')}'");
            Console.WriteLine($"PadRight(15, '') of '{text1}': '{text1.PadRight(15, '*')}'\n");

            Console.WriteLine("13. IsNullOrEmpty() and IsNullOrWhiteSpace():");
            string emptyString = "";
            string nullString = null;
            string whitespaceString = "   ";

            Console.WriteLine($"IsNullOrEmpty('{text1}'): {string.IsNullOrEmpty(text1)}");
            Console.WriteLine($"IsNullOrEmpty('{emptyString}'): {string.IsNullOrEmpty(emptyString)}");
            Console.WriteLine($"IsNullOrEmpty(null): {string.IsNullOrEmpty(nullString)}");
            Console.WriteLine($"IsNullOrWhiteSpace('{whitespaceString}'): {string.IsNullOrWhiteSpace(whitespaceString)}\n");

            Console.WriteLine("14. Join():");
            string[] words = { "Hello", "Beautiful", "World" };
            string joined = string.Join(" ", words);
            Console.WriteLine($"Join array with space: '{joined}'\n");

            Console.WriteLine("=== String Methods Demonstration Complete ===");
        }
    }
}
