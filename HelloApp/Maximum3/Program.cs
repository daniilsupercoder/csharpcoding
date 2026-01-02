using System.Diagnostics.Tracing;

namespace Max2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int max;
            max = Maximum(new[] { 2, 3, 6, 5, 4 });
            Console.WriteLine(max);
        }

        static int Maximum(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
    }
}
