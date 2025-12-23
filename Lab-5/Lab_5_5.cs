using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_Sem_5
{
    public class Dictionary
    {
        private System.Collections.Generic.Dictionary<int, string> dict = new System.Collections.Generic.Dictionary<int, string>();

        public void Add(int key, string value)
        {
            if (!dict.ContainsKey(key))
                dict.Add(key, value);
            else
                Console.WriteLine($"Key {key} already exists.");
        }

        public void Remove(int key)
        {
            if (dict.Remove(key))
                Console.WriteLine($"Removed key {key}.");
            else
                Console.WriteLine($"Key {key} not found.");
        }

        public void ContainsKey(int key)
        {
            if (dict.ContainsKey(key))
                Console.WriteLine($"Dictionary contains key {key}.");
            else
                Console.WriteLine($"Dictionary does not contain key {key}.");
        }

        public void ContainsValue(string value)
        {
            if (dict.ContainsValue(value))
                Console.WriteLine($"Dictionary contains value {value}.");
            else
                Console.WriteLine($"Dictionary does not contain value {value}.");
        }

        public void Clear()
        {
            dict.Clear();
        }

        public void Display()
        {
            if (dict.Count == 0)
            {
                Console.WriteLine("Dictionary is empty.");
                return;
            }
            Console.WriteLine("Dictionary contents:");
            foreach (var kvp in dict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
    }
}

