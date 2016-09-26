using System;

namespace Exercises_06_StringsAndObjects
{
    class Program
    {
        static void Main()
        {
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();

            object stringSumObj = string1 + " " + string2;

            string stringSum = (string)stringSumObj;

            Console.WriteLine(stringSum);
        }
    }
}
