using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_Sem_5
{
    internal class StudentList
    {
        private List<string> studentNames = new List<string>();

        public void Add(string studentName)
        {
            studentNames.Add(studentName);
        }

        public void Remove(int index)
        {
            if (index >= 0 && index < studentNames.Count)
                studentNames.RemoveAt(index);
            else
                Console.WriteLine("Invalid index.");
        }

        public void RemoveRange(int startIndex, int count)
        {
            if (startIndex >= 0 && count >= 0 && startIndex + count <= studentNames.Count)
                studentNames.RemoveRange(startIndex, count);
            else
                Console.WriteLine("Invalid range.");
        }

        public void Clear()
        {
            studentNames.Clear();
        }

        public void Display()
        {
            if (studentNames.Count == 0)
            {
                Console.WriteLine("No students in the list.");
                return;
            }
            Console.WriteLine("Student List:");
            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine($"{i}: {studentNames[i]}");
            }
        }
    }
}

