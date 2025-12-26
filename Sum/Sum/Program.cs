using System;

namespace Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 7, 8, 24, 15, 0, 0}; // summa 54

            // Summa
            int sum = 0;

            int counter = 5; //6 //7 //8 

            for (int i = 0; i < intArray.Length; i++)
            {
                sum = sum + intArray[i];
                counter++;
                //counter = counter + 1;
            }

            Console.WriteLine("Summa");
            Console.WriteLine(sum);

            Console.WriteLine();

            // Proizvenie
            int[] intArray2  = { 7, 8, 3, 2 }; // proizvedenie 336
            int p = 1;

            for (int i = 0; i < intArray2.Length; i++)
            {
                p = p * intArray2[i];
            }

            Console.WriteLine("Proizvedenie");
            Console.WriteLine(p);
        }
    }
}
