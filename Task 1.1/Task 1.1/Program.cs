using System;

namespace Задача_1._1
{
    class Program
    {
        private static int Factorial(int number)
            => number <= 1 ? 1 : number * Factorial(number - 1);
        static void Main(string[] args)
        {
            Console.WriteLine($"Factorial(5) = {Factorial(5)}");
            Console.WriteLine($"Factorial(-4) = {Factorial(-4)}");
            Console.WriteLine($"Factorial(23) = {Factorial(23)}");
        }
    }
}
