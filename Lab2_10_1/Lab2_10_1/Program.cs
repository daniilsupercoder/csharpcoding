using System;

namespace Lab2_10_1
{
    internal class Program
    {
        const double a = 6.7;
        const double b = 1.8;

        static void Main(string[] args)
        {
            double x;

            x = -0.24;
            Console.WriteLine("x = -0.24");
            Console.WriteLine($"Answer is: {Answer(x)}");

            Console.WriteLine();

            x = 2.13;
            Console.WriteLine("x = 2.13");
            Console.WriteLine($"Answer is: {Answer(x)}");

            Console.ReadLine();
        }

        static double Answer(double x)
        {
            double result = 0;

            if (x <= 0)
            {
                result = Math.Sqrt(Math.Exp(2 * x - b) - 1);
            }
            
            if (x > 0)
            {
                result = 1 / (Math.Pow(x, 2) + a);
            }

            return result;
        }
    }
}
