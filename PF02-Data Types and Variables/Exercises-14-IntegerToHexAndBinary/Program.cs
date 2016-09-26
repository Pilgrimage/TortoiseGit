using System;

namespace Exercises_14_IntegerToHexAndBinary
{
    class Program
    {
        static void Main()
        {
            string numDecStr = Console.ReadLine();
            int numDec = int.Parse(numDecStr);

            string numHexStr = Convert.ToString(numDec, 16).ToUpper();
            string numBinStr = Convert.ToString(numDec, 2);

            Console.WriteLine(numHexStr);
            Console.WriteLine(numBinStr);

        }
    }
}
