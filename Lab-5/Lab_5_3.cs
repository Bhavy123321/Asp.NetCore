using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_Sem_5
{
    internal class StackInteger
    {
        private Stack<int> stack = new Stack<int>();

        public void Push(int value)
        {
            stack.Push(value);
        }

        public void Pop()
        {
            if (stack.Count > 0)
            {
                int removed = stack.Pop();
                Console.WriteLine($"Popped: {removed}");
            }
            else
            {
                Console.WriteLine("Stack is empty.");
            }
        }

        public void Peek()
        {
            if (stack.Count > 0)
            {
                Console.WriteLine($"Top item: {stack.Peek()}");
            }
            else
            {
                Console.WriteLine("Stack is empty.");
            }
        }

        public void Contains(int value)
        {
            if (stack.Contains(value))
                Console.WriteLine($"Stack contains {value}.");
            else
                Console.WriteLine($"Stack does not contain {value}.");
        }

        public void Clear()
        {
            stack.Clear();
        }

        public void Display()
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Stack is empty.");
                return;
            }
            Console.WriteLine("Stack contents:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}

