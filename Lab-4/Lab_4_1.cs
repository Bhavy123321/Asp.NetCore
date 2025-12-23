using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_Sem_5
{
    public class Lab_4_1
    {   
        public int Add(int a , int b)
        {
            Console.WriteLine("Addition in integer::" + (a + b));
            return a + b;
        }

        public double Add(double x, double y)
        {
            Console.WriteLine("Addition in float::" + (x + y));
            return x + y;
        }
    }
}
