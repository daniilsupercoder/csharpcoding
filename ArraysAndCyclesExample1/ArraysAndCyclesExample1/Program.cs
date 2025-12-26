using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndCyclesExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 Типы данных в массиве
            // Как объявить массив, то есть сделать переменную вида массив какого-то типа
            //[]
            //int[] массив целых чисел
            //double[] массив вещественных чисел с плавающ
            //string[] массив строк
            //char[] массив символов(букв)
            //bool[] true, false, false

            int[] myFirstArray = new int[] { -2, -1, 0, 1, 2, 7 };

            string[] myStringArray = new string[] { "Daniil", "Sergey", "Gagarin" };

            char[] myCharArray = new char[] { 'a', 'b', 'c', };

            // 2 Циклы
            // Бывает трёх видов
            // 1) for
            // i++ короткая запись (эквивалентно) i = i + 1
            // Индекссация массива всегда начинается с нуля
            
            for (int i = 0; i < myFirstArray.Length;)
            {
                Console.WriteLine(myFirstArray[i]);
                i++;
            }

            for (int j = 0; j < myStringArray.Length; j++)
            {

            }

            Console.WriteLine();

            // Прямой обход массива с начала
            for (int mySuperIndex = 0; mySuperIndex < myStringArray.Length; mySuperIndex++)
            {
                Console.WriteLine(myStringArray[mySuperIndex]);
            }

            Console.WriteLine();

            // Обратный обход
            // i-- эквивалетно длинной  записи i = i - 1
            for (int i = myStringArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"element[{i}] = {myStringArray[i]}");
            }

            for (int i = myFirstArray.Length - 1; i >= 0; i--)
            {
             
            }
        }
    }
}
