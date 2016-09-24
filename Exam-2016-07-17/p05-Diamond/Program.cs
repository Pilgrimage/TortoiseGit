using System;

namespace p05_Diamond
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int end = (-(2 * num + 1));

            for (int i = num; i >= end; i--)
            {
                if (i == num) // First line
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', num), new string('*', 3 * num));
                }
                else if (i == 0) // Zero line
                {
                    Console.WriteLine(new string('*', 5 * num));
                }
                else if (i == end) // Last line
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', (2*num+1)), new string('*', (num-2)));
                }

                else // Body of the diamond
                {
                    int iAbs = Math.Abs(i);
                    Console.WriteLine("{0}*{1}*{0}", new string('.', iAbs), new string('.', 5*num-2*iAbs-2));
                }
            }
        }
    }
}
