using System;

namespace Exercises_15_ComparingFloats__J16_
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double eps = 0.000001;

            double diff = Math.Abs(num1 - num2);

            if (diff>eps)
            {
                Console.WriteLine("False");
                // Console.WriteLine("The difference of {0} is too big(> eps)", diff);
            }
            else if (diff < eps)
            {
                Console.WriteLine("True");
                // Console.WriteLine("The difference {0} < eps", diff);
            }
            else
            {
                Console.WriteLine("False");
                // Console.WriteLine("Border case. The difference 0.000001 == eps.");
                // Console.WriteLine("We consider the numbers are different.");
            }

        }
    }
}
