namespace product2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            int[] intArray = { 1, 2, 3, 4, 5, 6, 7 };
           int p = product(intArray);

            Console.WriteLine("product");
            Console.WriteLine(p);
        }

        static int product(int[] intArray) 
        {
            int p = 1;
            
            for (int i = 0; i < intArray.Length; i++)
            {
                p = p * intArray[i];
            }
            return p;
        }
    }
}
