using System;

namespace Task_1._5
{
    internal class Program
    {

        static void InsertionSort(int row, int col, int[,] array)
        {
            for (int i = 0; i < row; i++)
            {
                for (int k = i + 1; k < row; k++)
                {
                    if (array[0, i] > array[0, k])
                    {
                        for (int j = 0; j < col; j++)
                        {
                            int temp = array[j, i];
                            array[j, i] = array[j, k];
                            array[j, k] = temp;
                        }
                    }
                }
            }
        }

        static void Generation(int row, int col, int[,] array)
        {
            Random rand = new Random();
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    array[i, j] = rand.Next(1, 100);

                    Console.Write(array[i, j] + "\t");
                }
                Console.Write("\n");
            }
        }

        static void ToDisplay(int row, int col, int[,] array)
        {
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.Write("\n");
            }
        }

        static void Main(string[] args)
        {
            const int N = 10;
            int[,] array = new int[10, 10];
            int row = N;
            int col = N;

            Program.Generation(row, col, array);
            Program.InsertionSort(row, col, array);
            Console.Write("\n");
            Program.ToDisplay(row, col, array);
        }
    }
}
