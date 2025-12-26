using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_23_1
{
    internal class Program
    {
        const double a = 1.43;
        const double b = 4.18;

        static void Main(string[] args)
        {

            double x;

            x = -3.29;
            Console.WriteLine("x = -3.29");
            Console.WriteLine($"Answer is: {Answer(x)}");

            Console.WriteLine();

            x = 1.64;
            Console.WriteLine("x = 1.64");
            Console.WriteLine($"Answer is: {Answer(x)}");

            Console.ReadLine();
        }

        static double Answer(double x)
        {
            double result = 0;

            if(x < -1)
            {
                result = a + 2 * (Math.Sqrt(Math.Sin(a * x) + 3));
            }

            if (x >= -1)
            {
                result = Math.Log(Math.Sqrt(Math.Pow(x, 2) + b));
            }

            return result;
        }
    }
}
