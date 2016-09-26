using System;

namespace Lab_02_CircleArea__12_Digits_Precision_
{
    class Program
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine($"{area:f12}");
        }
    }
}
