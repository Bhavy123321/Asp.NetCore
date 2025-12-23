using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_Sem_5
{
    public class Rectangle
    {
        private double length;
        private double width;
        private double area;

        public Rectangle()
        {
            Console.WriteLine("Enter Rectangle Dimensions:");
            Console.WriteLine("-------------------------");

            Console.Write("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());

            CalculateArea();
        }


        public void CalculateArea()
        {
            area = length * width;
        }

        public void DisplayRectangleDetails()
        {
            Console.WriteLine("\nRectangle Details:");
            Console.WriteLine("-----------------");
            Console.WriteLine($"Length: {length} units");
            Console.WriteLine($"Width: {width} units");
            Console.WriteLine($"Area: {area} square units");
        }
    }
}

