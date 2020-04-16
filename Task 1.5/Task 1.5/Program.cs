using System;

namespace Task_1._5
{
    internal class Program
    {
        private static void SelectionSort(int row, int col, int[,] array)
        {
            int temp = 0;
            for (int i = 0; i < row; i++)
            {
                for (int k = i + 1; k < row; k++)
                {
                    if (array[0, i] > array[0, k])
                    {
                        for (int j = 0; j < col; j++)
                        {
                            Swap(temp, array, i, j, k);
                        }
                    }
                }
            }
        }

        private static void Swap(int temp, int[,] array, int i, int j, int k)
        {
            temp = array[j, i];
            array[j, i] = array[j, k];
            array[j, k] = temp;
        }

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

        private static void ToDisplay(int row, int col, int[,] array)
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
            const int N = 5;
            int[,] array = new int[N, N];
            int row = N;
            int col = N;

            Console.WriteLine("Сгенерированные столбцы: \n");
            Program.Generate(array);
            Console.WriteLine("\nОтсортированные столбцы: ");
            Program.SelectionSort(row, col, array);
            Console.Write("\n");
            Program.ToDisplay(row, col, array);
        }

        private static void Main(string[] args)
        {
            Print();
        }
    }
}
