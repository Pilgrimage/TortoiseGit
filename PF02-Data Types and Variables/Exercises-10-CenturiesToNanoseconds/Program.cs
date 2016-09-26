using System;
using System.Numerics;

namespace Exercises_10_CenturiesToNanoseconds
{
    class Program
    {
        static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60;
            ulong seconds = (ulong)minutes * 60;
            ulong milliSec = seconds * 1000;
            ulong microSec = milliSec * 1000;
            BigInteger nanoSec = (BigInteger)microSec * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliSec} milliseconds = {microSec} microseconds = {nanoSec} nanoseconds");

            //Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliSec} milliseconds = {microSec} microseconds = {microSec}000 nanoseconds");  // Not Good Idea, but it's working

        }
    }
}
