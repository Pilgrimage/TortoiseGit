using System;

namespace Lab_04_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peoples = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            //int courses = (int)Math.Ceiling((double)peoples / capacity);

            double courses = (double)peoples / capacity;
            Console.WriteLine(Math.Ceiling(courses));
        }
    }
}
