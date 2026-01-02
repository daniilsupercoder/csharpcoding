using System.Collections;

namespace sum2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 7, 12, 24, 67, 72 };
            int sum = 0 ;
            for (int i = 0; i < intArray.Length; i++) 
            {
                sum = sum + intArray[i];
                
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
