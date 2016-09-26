using System;

namespace Exercises_05_BooleanVariable
{
    class Program
    {
        static void Main()
        {
            string wisdom = Console.ReadLine();
            bool wisdomJudge = Convert.ToBoolean(wisdom);

            Console.WriteLine(wisdomJudge ? "Yes" : "No");
        }
    }
}
