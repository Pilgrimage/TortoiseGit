using System;

namespace p04_Back_To_The_Past
{
    class Program
    {
        static void Main()
        {
            double moneyInherited = double.Parse(Console.ReadLine());
            int lastYear = int.Parse(Console.ReadLine());

            double expenses = 0;

            for (int i = 1800; i <= lastYear; i++)
            {
                double yearExpense = 12000 + (i % 2) * (50 * (18 + (i - 1800)));
                expenses = expenses + yearExpense;
            }

            double result = moneyInherited - expenses;

            if (result >=0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", result);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", (-result));
            }

        }
    }
}
