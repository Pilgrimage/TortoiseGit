using System;

namespace p01_Money
{
    class Program
    {
        static void Main()
        {
            double inBitcoin = double.Parse(Console.ReadLine());
            double inYuan = double.Parse(Console.ReadLine());
            double comProc = double.Parse(Console.ReadLine());

            double amountBGN = inBitcoin * 1168.0 + ((inYuan * 0.15) * 1.76);
            double amountEuro = (amountBGN / 1.95);

            Console.WriteLine(amountEuro*(1-(comProc/100.0)));
        }
    }
}
