using System;
using System.Globalization;
namespace Problema_Uri_Notas_Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if(0 <= N && N <= 1000000.00)
            {
                Console.WriteLine();

                Console.WriteLine("NOTES:");

                double hundred = N % 100; 
                Console.WriteLine(Math.Truncate(N / 100) + " notes of R$ 100.00");
                double fifty = hundred % 50;
                Console.WriteLine(Math.Truncate(hundred / 50) + " notes of R$ 50.00");
                double twenty = fifty % 20;
                Console.WriteLine(Math.Truncate(fifty / 20) + " notes of R$ 20.00");
                double ten = twenty % 10;
                Console.WriteLine(Math.Truncate(twenty / 10) + " notes of R$ 10.00");
                double five = ten % 5;
                Console.WriteLine(Math.Truncate(ten / 5) + " notes of R$ 05.00");
                double two = five % 2;
                Console.WriteLine(Math.Truncate(five / 2) + " notes of R$ 02.00");
                Console.WriteLine();

                Console.WriteLine("COINS:");

                double one = two % 1;
                Console.WriteLine(Math.Truncate(two / 1) + " coins of R$ 01.00");
                double fiftyCents = one % 0.50;
                Console.WriteLine(Math.Truncate(one / 0.50) + " coins of R$ 0.50");
                double twentyfiveCents = fiftyCents % 0.25;
                Console.WriteLine(Math.Truncate(fiftyCents / 0.25) + " coins of R$ 0.25");
                double tenCents = twentyfiveCents % 0.10;
                Console.WriteLine(Math.Truncate(twentyfiveCents / 0.10) + " coins of R$ 0.10");
                double fiveCents = tenCents % 0.05;
                Console.WriteLine(Math.Truncate(tenCents / 0.05) + " coins of R$ 0.05");
                double oneCent = fiveCents % 0.01;
                Console.WriteLine(Math.Truncate(fiveCents / 0.01) + " coins of R$ 0.01");
            }
            else
            {
                Console.WriteLine("Invalid value!");
            }
            Console.WriteLine();
        }
    }
}
