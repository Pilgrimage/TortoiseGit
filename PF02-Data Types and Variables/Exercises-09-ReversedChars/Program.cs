using System;

namespace Exercises_09_ReversedChars
{
    class Program
    {
        static void Main()
        {
            string[] lettersIn = new string[3];
            for (int i = 0; i < 3; i++)
            {
                lettersIn[i] = Console.ReadLine();
            }
            Console.WriteLine(lettersIn[2] + lettersIn[1] + lettersIn[0]);
        }
    }
}
