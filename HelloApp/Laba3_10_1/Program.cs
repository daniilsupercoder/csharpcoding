namespace Laba3_10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            for(int i = 27; i<=117; i++)
            {
                if (i % 2 == 0)
                {
                    if (i % 7 == 0)
                    { 
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
