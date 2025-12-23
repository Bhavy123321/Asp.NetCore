using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_Sem_5
{
    public interface Shape
    {
        double Circle(double radius);
        double Triangle(double baseLength, double height);
        double Square(double side);
    }

    public class AreaCalculator : Shape
    {
        public double Circle(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double Triangle(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        public double Square(double side)
        {
            return side * side;
        }
    }

    internal class Lab_3_7
    {
        public void Exp7()
        {
            AreaCalculator calculator = new AreaCalculator();

            Console.WriteLine("=== Shape Area Calculator ===\n");

            Console.WriteLine("1. Circle Area Calculation:");
            Console.Write("Enter radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double circleArea = calculator.Circle(radius);
            Console.WriteLine($"Area of circle with radius {radius}: {circleArea:F2}");
            Console.WriteLine();

            Console.WriteLine("2. Triangle Area Calculation:");
            Console.Write("Enter base length of triangle: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height of triangle: ");
            double height = Convert.ToDouble(Console.ReadLine());
            double triangleArea = calculator.Triangle(baseLength, height);
            Console.WriteLine($"Area of triangle with base {baseLength} and height {height}: {triangleArea:F2}");
            Console.WriteLine();

            Console.WriteLine("3. Square Area Calculation:");
            Console.Write("Enter side length of square: ");
            double side = Convert.ToDouble(Console.ReadLine());
            double squareArea = calculator.Square(side);
            Console.WriteLine($"Area of square with side {side}: {squareArea:F2}");
            Console.WriteLine();

            Console.WriteLine("=== Summary of Areas ===");
            Console.WriteLine($"Circle (radius {radius}): {circleArea:F2}");
            Console.WriteLine($"Triangle (base {baseLength}, height {height}): {triangleArea:F2}");
            Console.WriteLine($"Square (side {side}): {squareArea:F2}");
            Console.WriteLine();

            Console.WriteLine("=== Example with Fixed Values ===");
            Console.WriteLine($"Circle (radius 5): {calculator.Circle(5):F2}");
            Console.WriteLine($"Triangle (base 6, height 4): {calculator.Triangle(6, 4):F2}");
            Console.WriteLine($"Square (side 7): {calculator.Square(7):F2}");
        }
    }
}
