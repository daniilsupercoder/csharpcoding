namespace Laba3_22_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            for (int i = 25; i < 117; i++)
            {
                if (i % 2 == 0 && i % 17 == 0) 
                {
                 Console.WriteLine(i);
                }
            }
        }
    }
}
