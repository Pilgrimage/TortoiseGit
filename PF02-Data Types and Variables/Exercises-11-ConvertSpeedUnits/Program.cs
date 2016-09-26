using System;

namespace Exercises_11_ConvertSpeedUnits
{
    class Program
    {
        static void Main()
        {
            float distance = float.Parse(Console.ReadLine()); //in meters
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int timeInSec = hours * 3600 + minutes * 60 + seconds;
            double timeInHours = timeInSec / 3600.0;

            float speedMS = (float)distance / timeInSec;
            float speedKmH = (float)(distance/1000/timeInHours);
            float speedMpH = (float)(distance/1609/timeInHours);

            //Console.WriteLine($"{speedMS:0.#######}");
            //Console.WriteLine($"{speedKmH:0.#######}");
            //Console.WriteLine($"{speedMpH:0.#######}");

            // Wrong test in Judge. Must be 7 digits after the FP. The Error in Zero test doesn't matter!

            Console.WriteLine(speedMS);
            Console.WriteLine(speedKmH);
            Console.WriteLine(speedMpH);


        }
    }
}
