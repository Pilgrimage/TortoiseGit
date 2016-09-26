using System;

namespace Exercises_12_RectangleProperties
{
    class Program
    {
        static void Main()
        {
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());

            double perimeter = 2 * (side1 + side2);
            double area = side1 * side2;
            double diagonal = Math.Sqrt(side1 * side1 + side2 * side2);

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
