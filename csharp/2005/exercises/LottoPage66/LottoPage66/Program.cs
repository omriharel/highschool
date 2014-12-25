using System;
using System.Collections.Generic;
using System.Text;

namespace LottoPage66
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] table = GenerateTable();
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i, j] + ", ");
                }
                Console.WriteLine();
            }
            CheckWin(table);
        }

        static int[,] GenerateTable()
        {
            int[,] table = new int[5, 5];
            Random r = new Random();
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = r.Next(200, 501);
                }
            }
            return table;
        }

        static void CheckWin(int[,] table)
        {
            int sum = 0;
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    int[] surrounding = GetSurroundingNums(table, i, j);
                    bool add = true;
                    for (int k = 0; k < surrounding.Length; k++)
                    {
                        if (surrounding[k] != 0)
                        {
                            if (table[i, j] <= surrounding[k])
                            {
                                add = false;
                                break;
                            }
                        }
                    }
                    if (add)
                    {
                        Console.WriteLine("Added spot [" + i + ", " + j + "] to winning list. Value: " + table[i, j]);
                        sum += table[i, j];
                    }
                }
            }
            Console.WriteLine("You won " + sum + " dollars!");
        }

        private static int[] GetSurroundingNums(int[,] table, int x, int y)
        {
            switch (x)
            {
                case 0:
                    {
                        switch (y)
                        {
                            case 0:
                                {
                                    int[] s = new int[3];
                                    s[0] = table[x + 1, y];
                                    s[1] = table[x, y + 1];
                                    s[2] = table[x + 1, y + 1];
                                    return s;
                                }
                            case 4:
                                {
                                    int[] s = new int[3];
                                    s[0] = table[x, y - 1];
                                    s[1] = table[x + 1, y];
                                    s[2] = table[x + 1, y - 1];
                                    return s;
                                }
                            default:
                                {
                                    int[] s = new int[5];
                                    s[0] = table[x, y - 1];
                                    s[1] = table[x + 1, y - 1];
                                    s[2] = table[x + 1, y];
                                    s[3] = table[x + 1, y + 1];
                                    s[4] = table[x, y + 1];
                                    return s;
                                }
                        }
                    }
                case 4:
                    {
                        switch (y)
                        {
                            case 0:
                                {
                                    int[] s = new int[3];
                                    s[0] = table[x - 1, y];
                                    s[1] = table[x, y + 1];
                                    s[2] = table[x - 1, y + 1];
                                    return s;
                                }
                            case 4:
                                {
                                    int[] s = new int[3];
                                    s[0] = table[x - 1, y];
                                    s[1] = table[x, y - 1];
                                    s[2] = table[x - 1, y - 1];
                                    return s;
                                }
                            default:
                                {
                                    int[] s = new int[5];
                                    s[0] = table[x, y - 1];
                                    s[1] = table[x - 1, y - 1];
                                    s[2] = table[x - 1, y];
                                    s[3] = table[x - 1, y + 1];
                                    s[4] = table[x, y + 1];
                                    return s;
                                }
                        }
                    }
                default:
                    {
                        switch (y)
                        {
                            case 0:
                                {
                                    int[] s = new int[5];
                                    s[0] = table[x - 1, y];
                                    s[1] = table[x - 1, y + 1];
                                    s[2] = table[x, y + 1];
                                    s[3] = table[x + 1, y + 1];
                                    s[4] = table[x + 1, y];
                                    return s;
                                }
                            case 4:
                                {
                                    int[] s = new int[5];
                                    s[0] = table[x - 1, y];
                                    s[1] = table[x - 1, y - 1];
                                    s[2] = table[x, y - 1];
                                    s[3] = table[x + 1, y - 1];
                                    s[4] = table[x + 1, y];
                                    return s;
                                }
                            default:
                                {
                                    int[] s = new int[8];
                                    s[0] = table[x - 1, y];
                                    s[1] = table[x - 1, y - 1];
                                    s[2] = table[x, y - 1];
                                    s[3] = table[x + 1, y - 1];
                                    s[4] = table[x + 1, y];
                                    s[5] = table[x + 1, y + 1];
                                    s[6] = table[x, y + 1];
                                    s[7] = table[x - 1, y + 1];
                                    return s;
                                }
                        }
                    }
            }
        }
    }
}
