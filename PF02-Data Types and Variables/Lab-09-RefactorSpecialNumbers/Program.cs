using System;

namespace Lab_09_RefactorSpecialNumbers
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int current = 0;
            bool special = false;

            for (int i = 1; i <= num; i++)
            {
                current = i;
                while (current > 0)
                {
                    sum += current % 10;
                    current = current / 10;
                }

                special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {special}");
                sum = 0;
            }
        }
    }
}
