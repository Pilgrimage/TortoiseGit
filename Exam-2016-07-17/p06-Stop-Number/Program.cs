using System;

namespace p06_Stop_Number
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); // N – цяло число – 0 <= N <M
            int m = int.Parse(Console.ReadLine()); // M – цяло число – N < M <= 10000
            int stopNum = int.Parse(Console.ReadLine()); // S – цяло числo – N <= S <=M


            for (int i = m; i >= n; i--)
            {
                if ((i%2 + i%3)==0)   // Или може да се дели на 6 като май-малко общо кратно на 2 и 3
                {
                    if (i != stopNum)
                    {
                        Console.Write(i + " ");
                        i -= 5;  // оптимизация - проверка през 6 след първото делимо на 6
                    }
                    else break;
                }
            }


        }
    }
}
