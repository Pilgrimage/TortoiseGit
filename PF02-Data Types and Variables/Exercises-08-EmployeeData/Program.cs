using System;

namespace Exercises_08_EmployeeData
{
    class Program
    {
        static void Main()
        {
            string[] titul = new string[6] { "First name", "Last name", "Age", "Gender", "Personal ID", "Unique Employee number" };
            string firstName = "Amanda";
            string lastName = "Jonson";
            byte age = 27;
            char gender = 'f';
            long personalId = 8306112507;
            int uniqueEmpNum = 27563571;

            Console.WriteLine("{0}: {1}", titul[0], firstName);
            Console.WriteLine("{0}: {1}", titul[1], lastName);
            Console.WriteLine("{0}: {1}", titul[2], age);
            Console.WriteLine("{0}: {1}", titul[3], gender);
            Console.WriteLine("{0}: {1}", titul[4], personalId);
            Console.WriteLine("{0}: {1}", titul[5], uniqueEmpNum);
        }
    }
}
