using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_Sem_5
{
    internal class QueueInteger
    {
        private Queue<int> queue = new Queue<int>();

        public void Enqueue(int value)
        {
            queue.Enqueue(value);
        }

        public void Dequeue()
        {
            if (queue.Count > 0)
            {
                int removed = queue.Dequeue();
                Console.WriteLine($"Dequeued: {removed}");
            }
            else
            {
                Console.WriteLine("Queue is empty.");
            }
        }

        public void Peek()
        {
            if (queue.Count > 0)
            {
                Console.WriteLine($"First item: {queue.Peek()}");
            }
            else
            {
                Console.WriteLine("Queue is empty.");
            }
        }

        public void Contains(int value)
        {
            if (queue.Contains(value))
                Console.WriteLine($"Queue contains {value}.");
            else
                Console.WriteLine($"Queue does not contain {value}.");
        }

        public void Clear()
        {
            queue.Clear();
        }

        public void Display()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }
            Console.WriteLine("Queue contents:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}

