using System;

namespace Lab_06_TriplesOfLatinLetters
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    for (int k = 0; k < num; k++)
                    {
                        char letter1 = (char)('a' + i);
                        char letter2 = (char)('a' + j);
                        char letter3 = (char)('a' + k);

                        Console.WriteLine(letter1.ToString() + letter2.ToString() + letter3.ToString());
                    }
                }
            }
        }
    }
}
