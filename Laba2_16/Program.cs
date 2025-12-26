using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_16
{
    internal class Program
    {
        public static double e = Math.E;

        public static double a = 7.5;

        public static double b = 1.4;


        static void Main(string[] args)
        {
            double result = 0;

            result = Solve(-4.13);
            Console.WriteLine(result);


            result = Solve(0.77);
            Console.WriteLine(result);

            Console.ReadLine();
        }

        static double Solve(double x)
        {            
            double result = 0;

            if (x <= -3)
            {
                result = a - Math.Pow(b, b) * x;
            }

            if (x > -3)// else
            {
                result = 1 / (Math.Pow(x, x) + Math.Pow(Math.E, b * x));
            }

            return result;
        }

        /// <summary>
        /// This is Cool multiline comment
        /// </summary>
        void Solve2()
        {
            // This is a Procedure in another languages
        }
    }
}
