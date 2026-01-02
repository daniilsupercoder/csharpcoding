using System.Diagnostics.Tracing;

namespace minimum2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int min;
            min = Minimum(new[] { 3, 5, 8, 2, 1 });
            Console.WriteLine(min);
        }

        static int Minimum(int[] numbers)
        {
            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }
    }
}
