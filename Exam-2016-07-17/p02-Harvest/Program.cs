using System;

namespace p02_Harvest
{
    class Program
    {
        static void Main()
        {
            int area = int.Parse(Console.ReadLine());         // Площ на лозето в квадратни метри
            double grapes = double.Parse(Console.ReadLine()); // Добив = кг от квадратен метър
            int wineMustHave = int.Parse(Console.ReadLine()); // Neobhodimi litri wino
            int peoples = int.Parse(Console.ReadLine());

            double grapeAmount = area * 0.4 * grapes;         // Добито грозде
            double wineAmount = grapeAmount / 2.5;            // Добито вино

            if (wineAmount < wineMustHave)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(wineMustHave - wineAmount));
            }
            else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wineAmount));
                var rest = (wineAmount - wineMustHave);
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(rest), Math.Ceiling(rest / peoples));
            }
        }
    }
}
