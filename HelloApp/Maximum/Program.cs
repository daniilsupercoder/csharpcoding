namespace Maximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int max;
            max = Maximum(new[] {3, 5, 8, 2, 1});
            Console.WriteLine(max);
        }

        static int Maximum(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++) 
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
