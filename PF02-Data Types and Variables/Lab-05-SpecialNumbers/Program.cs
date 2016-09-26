using System;
using System.Collections.Generic;

namespace Lab_05_SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInt = int.Parse(Console.ReadLine());
            int magic = 0;
            bool special = false;

            for (int i = 1; i <= numInt; i++)   // 
            {
                /*
                for (int j = 0; j < numString.Length; j++)
                {
                    magic = magic + Convert.ToInt32(numString[j] - 48); // Becouse it return ASCII Number, divide 48 to convert in number
                }
                */
                int current = i;
                while (current != 0)
                {
                    magic = magic + current % 10;
                    current = current / 10;
                }
                if (magic == 5 || magic == 7 || magic == 11)
                    special = true;
                else
                    special = false;

                Console.WriteLine(i + " -> " + (special ? "True" : "False"));

                magic = 0;
            }
        }
    }
}
