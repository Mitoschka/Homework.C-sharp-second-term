using System;

/// <summary>
/// Global namespace.
/// </summary>
namespace Task_2._3
{
    /// <summary>
    /// Program launch
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Launches programs
        /// </summary>
        private static void Main()
        {
            bool flag = false;

            while (!flag)
            {
                flag = true;
                Console.WriteLine("[ОБРАТНАЯ ПОЛЬСКАЯ ЗАПИСЬ]");
                int number = -1;

                Console.Write("\nВведите номер реализации: " + "\n");
                Console.Write("'1' - Реализация листом \n" +
                              "'2' - Реализация массивом \n");
                bool isCorrecting = false;
                while (!isCorrecting)
                {
                    try
                    {
                        number = Convert.ToInt32(Console.ReadLine());
                        isCorrecting = true;
                    }
                    catch (FormatException error)
                    {
                        Console.Clear();
                        Console.WriteLine(error.Message);
                        isCorrecting = false;
                    }
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

                try
                {
                    var myCalculator = new Calculator(stack);
                    Console.WriteLine("Введите арифметическое выражение в виде обратной польской записи: ");
                    string expression = Console.ReadLine();
                    Console.WriteLine($"Результат выражения: {myCalculator.CalculateTheResultOfOperations(expression)}");
                }
                catch (InvalidOperationException)
                {
                    flag = false;
                }
                catch (ArgumentException)
                {
                    flag = false;
                }
            }
        }
    }
}

