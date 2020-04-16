using System;

namespace Task_1._4
{
    internal class Program
    {
        const int sizeOfMatrix = 5;
        static int[,] MatrixFilling(int line, int column)
        {
            int num = 0;
            int size = line * column;
            int[,] array = new int[line, column];

            Console.WriteLine("Исходный массив:\n ");

            for (int i = 0; i < sizeOfMatrix; i++)
            {
                for (int j = 0; j < sizeOfMatrix; j++)
                {
                    array[i, j] = num;
                    Console.Write("{0}\t", array[i, j]);
                    num++;
                }
                Console.WriteLine("\n");
            }
            return array;
        }

        static void MatrixOutput(int[,] array)
        {
            int[,] movement = new int[4, 2] { { -1, 0 }, { 0, -1 }, { 1, 0 }, { 0, 1 } };
            int move = 1;
            int position = 0;
            int horizontally = sizeOfMatrix / 2;
            int upright = sizeOfMatrix / 2;

            Console.WriteLine("\nОтвет:\n");

            while (move < sizeOfMatrix)
            {
                for (int i = 0; i < move; i++)
                {
                    Console.Write($" {array[horizontally, upright]} ");
                    horizontally += movement[position, 0];
                    upright += movement[position, 1];
                }

                position = (position + 1) % 4;
                if (position % 2 == 0)
                {
                    move++;
                }
            }

            for (int i = 0; i < sizeOfMatrix; i++)
            {
                Console.Write($" {array[horizontally, upright]} ");
                horizontally += movement[position, 0];
                upright += movement[position, 1];
            }
        }

        static void Main(string[] args)
        {
            int line = sizeOfMatrix;
            int column = sizeOfMatrix;
            int[,] array = Program.MatrixFilling(line, column);
            MatrixOutput(array);
        }
    }
}
