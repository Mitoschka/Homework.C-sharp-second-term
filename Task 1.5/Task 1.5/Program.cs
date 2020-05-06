using System;

namespace Task_1._5
{
    internal class Program
    {
        private const int N = 5;
        private const int row = N;
        private const int col = N;

        private static void Generate(int[,] array)
        {
            var rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(1, 100);

                    Console.Write(array[i, j] + "\t");
                }
                Console.Write("\n");
            }
        }

        private static int[,] ColumnSort(int[,] array)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    if (array[0, j] > array[0, j + 1])
                    {
                        Swap(array, j);
                    }
                }
            }
            return array;
        }

        private static void Swap(int[,] array, int j)
        {
            for (int k = 0; k < array.GetLength(0); k++)
            {
                (array[k, j], array[k, j + 1]) = (array[k, j + 1], array[k, j]);
            }
        }

        private static void ToDisplay(int[,] array)
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

        private static void Print()
        {
            int[,] array = new int[N, N];

            Console.WriteLine("Сгенерированные столбцы: \n");
            Program.Generate(array);
            Console.WriteLine("\nОтсортированные столбцы: ");
            Program.ColumnSort(array);
            Console.Write("\n");
            Program.ToDisplay(array);
        }

        private static void Main(string[] args)
        {
            Print();
        }
    }
}
