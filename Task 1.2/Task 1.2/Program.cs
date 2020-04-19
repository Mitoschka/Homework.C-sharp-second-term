using System;

namespace Task_1._2
{
    class Program
    {
        private static long[] numbersOfFibonacci;

        private static long Fibonacci(long number)
        {
            if (numbersOfFibonacci[number] == 0 && number > 1)
            {
                numbersOfFibonacci[number] = Fibonacci(number - 1) + Fibonacci(number - 2);
            }
            return numbersOfFibonacci[number];
        }

        static void Main(string[] args)
        {
            numbersOfFibonacci = new long[100];
            numbersOfFibonacci[1] = 1;
            Console.WriteLine($"Fibonacci(50) = {Fibonacci(50)}");
            Console.WriteLine($"Fibonacci(23) = {Fibonacci(23)}");
            Console.WriteLine($"Fibonacci(9) = {Fibonacci(9)}");
            Console.WriteLine($"Fibonacci(0) = {Fibonacci(0)}");
            Console.WriteLine($"Fibonacci(1) = {Fibonacci(1)}");
        }
    }
}
