using System;

namespace Задача_1._3
{
    class Program
    {
        //метод для обмена элементов массива
        static void Swap(ref int first, ref int second)
        {
            var intermediate = first;
            first = second;
            second = intermediate;
        }

        //метод возвращающий индекс опорного элемента
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        //быстрая сортировка
        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("N = ");
            var len = Convert.ToInt32(Console.ReadLine());
            var array = new int[len];
            for (var i = 0; i < array.Length; ++i)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", QuickSort(array)));

            Console.ReadLine();
        }
    }
}
