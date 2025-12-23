using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_Sem_5
{
    internal class Lab_3_1
    {  
        public void Exp1()
        {
            try
            {
                Console.WriteLine("Enter First Number ::: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number ::: ");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Result :::: "+(x/y));
            }
            catch (DivideByZeroException ex){
                Console.WriteLine("Error Occured");
                Console.WriteLine(ex.Message);
            }
                
        }
    }
}
