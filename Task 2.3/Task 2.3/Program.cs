using System;

namespace Task_2._3
{
    /// <summary>
    /// Program launch
    /// </summary>
    class Program
    {
        /// <summary>
        /// Launches programs
        /// </summary>
        static void Main()
        {
            Console.WriteLine("[ОБРАТНАЯ ПОЛЬСКАЯ ЗАПИСЬ]");
            int number = -1;

            Console.Write("\nВведите номер реализации: " + "\n");
            Console.Write("'1' - Реализация листом \n" +
                          "'2' - Реализация массивом \n");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException error)
            {
                Console.Clear();
                Console.WriteLine(error.Message);
            }

            IStack stack;

            switch (number)
            {
                case 1:
                    {
                        stack = new StackOnList();
                        break;
                    }
                case 2:
                    {
                        stack = new StackOnArray();
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        stack = new StackOnArray();
                        Console.WriteLine("Я не знаю такой команды. \n" +
                            "По умолчанию запустится реализация на массиве." + "\n");
                        break;
                    }
            }

            Calculator myCalculator = new Calculator(stack);
            Console.WriteLine("Введите арифметическое выражение в виде обратной польской записи: ");
            string expression = Console.ReadLine();
            Console.WriteLine($"Результат выражения: {myCalculator.ResultOfOperations(expression)}");
        }
    }
}

