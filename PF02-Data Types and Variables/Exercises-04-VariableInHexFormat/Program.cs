using System;

namespace Exercises_04_VariableInHexFormat
{
    class Program
    {
        static void Main()
        {
            string hexNumStr = Console.ReadLine();
            int decNum = Convert.ToInt32(hexNumStr, 16);

            Console.WriteLine(decNum);
        }
    }
}
