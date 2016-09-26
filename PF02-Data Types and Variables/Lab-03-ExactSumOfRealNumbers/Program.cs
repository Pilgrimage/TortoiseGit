using System;

namespace Lab_03_ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            decimal result = 0m;

            for (int i = 0; i < numbers; i++)
            {
                result += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(result);
        }
    }
}
