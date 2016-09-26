using System;

namespace Exercises_07_ExchangeVariableValues
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            // Variant 1

            Console.WriteLine($"Before:\r\na = {a}\r\nb = {b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After:\r\na = {a}\r\nb = {b}");

            // Variant 2 - without temp variable
            /*
            if (a > b)
            {
                a -= b;       // a = a - b
                b += a;       // b = b + a
                a = b - a;    // a = b - a
            }
            */
        }
    }
}
