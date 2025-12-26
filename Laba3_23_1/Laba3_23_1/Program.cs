using System;

namespace Laba3_23_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 1000;
            int percent = 2;
            int month = 1;

            while (month <= 12)
            {
                sum = sum + sum / 100 * percent;

                sum = Math.Round(sum, 2);

                Console.WriteLine($"Month = {month} Sum = {sum}");

                month++;
            }

            Console.WriteLine();

            Console.WriteLine($"Total Sum = {sum}");
        }
    }
}
