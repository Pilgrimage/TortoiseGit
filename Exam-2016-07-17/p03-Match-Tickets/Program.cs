using System;

namespace p03_Match_Tickets
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peoples = int.Parse(Console.ReadLine());

            double budgetForTickets = 0.0;

            if (peoples >= 50)
            {
                budgetForTickets = budget * 0.75;
            }
            else if (peoples >= 25)
            {
                budgetForTickets = budget * 0.60;
            }
            else if (peoples >= 10)
            {
                budgetForTickets = budget * 0.50;
            }
            else if (peoples >= 5)
            {
                budgetForTickets = budget * 0.40;
            }
            else if (peoples >= 1)
            {
                budgetForTickets = budget * 0.25;
            }

            if (category == "VIP")
            {
                double amount = peoples * 499.99;

                if (budgetForTickets >= amount)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", (budgetForTickets - amount));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", (amount - budgetForTickets));
                }
            }

            else if (category == "Normal")
            {
                double amount = peoples * 249.99;

                if (budgetForTickets >= amount)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", (budgetForTickets - amount));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", (amount - budgetForTickets));
                }
            }
        }
    }
}
