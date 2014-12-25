using System;
using System.Collections.Generic;
using System.Text;

namespace MagicSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] square = InitializeArray(3, 3);
            bool isMagic = CheckMagic(square);
            Console.WriteLine("Is your square magic? " + isMagic + ".");
        }

        private static int[,] InitializeArray(int i, int j)
        {
            Console.WriteLine("Enter values for array: (" + i + "x" + j + ")");
            int[,] array = new int[i, j];
            for (int m = 0; m < array.GetLength(0); m++)
            {
                Console.WriteLine("Line " + (m + 1) + ":");
                for (int n = 0; n < array.GetLength(1); n++)
                {
                    array[m, n] = int.Parse(Console.ReadLine());
                }
            }
            return array;
        }

        private static bool CheckMagic(int[,] array)
        {
            int equalValue = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                if (i == 0)
                    equalValue = SumLine(array, i);
                else
                {
                    if (SumLine(array, i) != equalValue)
                        return false;
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (SumRow(array, i) != equalValue)
                {
                    return false;
                }
            }
            return true;
        }

        private static int SumLine(int[,] array, int line)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[line, i];
            }
            return sum;
        }

        private static int SumRow(int[,] array, int row)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                sum += array[i, row];
            }
            return sum;
        }
    }
}
