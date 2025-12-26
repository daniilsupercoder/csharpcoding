using System;

class Program
{
    /// <summary>
    /// Fibonachi
    /// </summary>
    static void Main()
    {
        Console.Write("Enter an integer N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Fibonacci numbers from F1 to F{n}:");

        for (int k = 1; k <= n; k++)
        {
            Console.WriteLine($"F{k} = {FibonacciRecursive(k)}");
        }
    }

    /// <summary>
    /// 1, 1, 2, 3, 5, ...
    /// </summary>
    /// <param name="k"></param>
    /// <returns></returns>
    static long FibonacciRecursive(int k)
    {
        if (k <= 0) return 0;
        if (k == 1 || k == 2) return 1;
        return FibonacciRecursive(k - 2) + FibonacciRecursive(k - 1);
    }
}