using System;

namespace Task_1._4
{
    internal class Program
    {
        const int N = 13;

        static int[,] FillingOut(int line, int column)
        {
            int size = line * column;
            int[,] array = new int[line, column];

            int horizontally = 0;
            int upright = 0;
            int maxColumn = N - 1;
            int minColumn = 0;
            int maxRow = N - 1;
            int minRow = 0;


            while (size > 1)
            {
                //Движемся вправо.
                while (upright <= maxColumn)
                {
                    array[horizontally, upright] = size;
                    size--;
                    upright++;
                }
                ++minRow;
                --upright;
                ++horizontally;

                //Движемся вниз.
                while (horizontally <= maxRow)
                {
                    array[horizontally, upright] = size;
                    size--;
                    horizontally++;
                }
                --maxColumn;
                --horizontally;
                --upright;


                //Движемся влево.
                while (upright >= minColumn)
                {
                    array[horizontally, upright] = size;
                    size--;
                    upright--;
                }
                --maxRow;
                ++upright;
                --horizontally;

                //Движемся вверх.
                while (horizontally >= minRow)
                {
                    array[horizontally, upright] = size;
                    size--;
                    horizontally--;
                }
                ++minColumn;
                ++horizontally;
                ++upright;
            }
            array[N / 2, N / 2] = 1;
            return array;
        }
        static void Main(string[] args)
        {
            int line = N;
            int column = N;
            int[,] array = Program.FillingOut(line, column);

            //Выводим массив в консоль.
            for (int firstHorizontally = 0; firstHorizontally < line; firstHorizontally++)
            {
                for (int firstUpright = 0; firstUpright < column; firstUpright++)
                {
                    Console.Write(array[firstHorizontally, firstUpright] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
