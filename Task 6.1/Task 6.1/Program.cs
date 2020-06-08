using System;
using System.Collections.Generic;

namespace Task_6._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var listOfMap = new List<int>();

            listOfMap.Add(0);
            listOfMap.Add(1);
            listOfMap.Add(2);
            listOfMap.Add(3);
            listOfMap.Add(4);

            listOfMap = MapFunction.Map(listOfMap, x => x * 2);

            Console.Write("Map: ");
            for (int i = 0; i != listOfMap.Count; i++)
            {
                Console.Write($"{listOfMap[i]} ");
            }

            Console.Write("\n");

            var listOfFilter = new List<int>();

            listOfFilter.Add(0);
            listOfFilter.Add(1);
            listOfFilter.Add(2);
            listOfFilter.Add(-1);
            listOfFilter.Add(3);
            listOfFilter.Add(4);
            listOfFilter.Add(-4);

            listOfFilter = FilterFunction.Filter(listOfFilter, x => x > 0);
            Console.Write("Filter: ");
            for (int i = 0; i != listOfFilter.Count; i++)
            {
                Console.Write($"{listOfFilter[i]} ");
            }

            Console.Write("\n");

            var listOfFold = new List<int>();
            int result = 0;

            listOfFold.Add(1);
            listOfFold.Add(2);
            listOfFold.Add(3);
            listOfFold.Add(4);

            result = FoldFunction.Fold(listOfFold, 1, (x,y) => x * y);
            Console.Write("Fold:\tList: ");
            for (int i = 0; i != listOfFold.Count; i++)
            {
                Console.Write($"{listOfFold[i]} ");
            }
            Console.Write($"\n\tResult: {result}");
        }
    }
}
