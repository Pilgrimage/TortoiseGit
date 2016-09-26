using System;

namespace Exercises_13_VowelOrDigit
{
    class Program
    {
        static void Main()
        {
            char question = char.Parse(Console.ReadLine());

            switch (question)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    Console.WriteLine("digit");
                    break;

                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'y':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                case 'Y':
                    Console.WriteLine("vowel");
                    break;

                default:
                    Console.WriteLine("other");
                    break;
            }
        }
    }
}
