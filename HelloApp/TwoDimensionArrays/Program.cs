using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intOneDimensionArray = { 1, 2, 3, 4, 5, };

            int[,] intTwoDimensionsArray = { 
                { 1, 2, 3, 11, 12 }, 
                {3, 4, 5, 11, 12}, 
                {5, 6, 7, 11, 12},
                {3, 4, 5, 11, 12},
                {5, 6, 7, 11, 12},

            };

            // Есть соглашение, что количество строк обозначается буквами m или M
            // а количество столбцов обозначается буквами n или N
            // Таким образом, матрица (M x N) или (m x n)
            // Например (2 x 3) (3 x 3) (25 x 25) (7 x 2)
            // (113 x 78)
            // (rows x columns)

            for(int row = 0; row < intTwoDimensionsArray.GetLength(0); row++)
            {
                for (int col = 0; col < intTwoDimensionsArray.GetLength(1); col++)
                {
                    Console.Write($"{intTwoDimensionsArray[row, col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
