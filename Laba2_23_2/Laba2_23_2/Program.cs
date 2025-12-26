using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_23_2
{

    internal class Program
    {
        const double a = 2.2;
        const double b = 3.4;

        static void Main(string[] args)
        {
            double x;

            x = 6.47;
            Console.WriteLine("x = 6.47");
            Console.WriteLine($"Answer is: {Answer(x)}");

            Console.WriteLine();

            x = -5.9;
            Console.WriteLine("x = -5.9");
            Console.WriteLine($"Answer is: {Answer(x)}");

            Console.WriteLine();

            x = 1.94;
            Console.WriteLine("x = 1.94");
            Console.WriteLine($"Answer is: {Answer(x)}");

            Console.ReadLine();
        }

        static double Answer(double x)
        {
            double result = 0;

            if (x >= 5)
            {
                result = Math.Pow(Math.Sin(Math.Sqrt(a + Math.Abs(x))), 2);
            }

            if (x <= -3)
            {
                result = Math.Pow(Math.E, b / x) + 1;
            }

            if ((-3 < x) && (x < 5))
            {
                result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(b, 3) * a);
            }

            return result;
        }
    }
}
