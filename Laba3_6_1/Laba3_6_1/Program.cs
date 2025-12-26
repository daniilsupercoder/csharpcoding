namespace Laba3_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            for(int i = 0; i <+1025; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
    
}
