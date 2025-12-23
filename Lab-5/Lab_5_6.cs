using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_Sem_5
{
    internal class Hashtable
    {
        private System.Collections.Hashtable hashtable = new System.Collections.Hashtable();

        public void Add(object key, object value)
        {
            if (!hashtable.ContainsKey(key))
                hashtable.Add(key, value);
            else
                Console.WriteLine($"Key {key} already exists.");
        }

        public void Remove(object key)
        {
            if (hashtable.ContainsKey(key))
            {
                hashtable.Remove(key);
                Console.WriteLine($"Removed key {key}.");
            }
            else
                Console.WriteLine($"Key {key} not found.");
        }

        public void ContainsKey(object key)
        {
            if (hashtable.ContainsKey(key))
                Console.WriteLine($"Hashtable contains key {key}.");
            else
                Console.WriteLine($"Hashtable does not contain key {key}.");
        }

        public void ContainsValue(object value)
        {
            if (hashtable.ContainsValue(value))
                Console.WriteLine($"Hashtable contains value '{value}'.");
            else
                Console.WriteLine($"Hashtable does not contain value '{value}'.");
        }

        public void Clear()
        {
            hashtable.Clear();
        }

        public void Display()
        {
            if (hashtable.Count == 0)
            {
                Console.WriteLine("Hashtable is empty.");
                return;
            }
            Console.WriteLine("Hashtable contents:");
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }
    }
}
