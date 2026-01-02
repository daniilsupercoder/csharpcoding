namespace SredneeArifmeticheskoe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] numbers = { 1, 2, 3, 6};

            double sa;

            sa = SredneeArifmeticheskoe(numbers);

            Console.WriteLine(sa);
        }

        static double SredneeArifmeticheskoe(int[] numbers)
        {
            double result = 0;

            foreach (int i in numbers)
            {
                //result += i;
                result = result + i;
            }

            result = result / numbers.Length;

            return result;
        }
    }
}
