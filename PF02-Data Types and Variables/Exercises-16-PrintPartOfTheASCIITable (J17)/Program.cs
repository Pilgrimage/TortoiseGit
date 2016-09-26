using System;

namespace Exercises_16_PrintPartOfTheASCIITable__J17_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBeg = int.Parse(Console.ReadLine());
            int numEnd = int.Parse(Console.ReadLine());

            for (int i = numBeg; i <= numEnd; i++)
            {
                string asciiChar = ((char)i).ToString();
                Console.Write(asciiChar + " ");
            }
        }
    }
}
