using System;

namespace Task_3._2
{
    public class Program
    {
        static void PrintMenu()
        {
            Console.WriteLine("[МЕНЮ КОМАНД]: \n" +
            "'0' - Выход из программы \n" +
            "'1' - Добавить значение в хеш-таблицу \n" +
            "'2' - Удалить значение в хеш-таблице \n" +
            "'3' - Проверить значение на принадлежность \n" +
            "'4' - Изменить хэш - функцию \n" +
            "'5' - Вызвать меню команд \n");
        }
        static void Main()
        {
            IMyHash myHash;
            myHash = new ThirdHash();
            HashTable hashTable = new HashTable(myHash);

            Console.Write("Это программа по работе с хэш - таблицей \n");
            Program.PrintMenu();

            int number = -1;

            while (number != 0)
            {
                Console.Write("\nВведите номер команды: " + "\n");
                Console.Write("'5' - Вызвать меню команд \n" + "\n");
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Clear();
                }

                switch (number)
                {
                    case 0:
                        {
                            Console.Clear();
                            Console.Write("[ПРОГРАММА ЗАВЕРШЕНА]" + "\n");
                            break;
                        }
                    case 1:
                        {
                            Console.Clear();
                            Console.Write("[ДОБАВЛЯЕМ ЗНАЧЕНИЕ В ХЭШ-ТАБЛИЦУ...]" + "\n" + "\n");
                            Console.Write("Введите значение элемента: " + "\n");
                            string value = (Console.ReadLine());
                            hashTable.AddElementToHashTable(value);
                            Console.WriteLine($"\"{value}\" было добавлено" + "\n");
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.Write("[УДАЛЯЕМ ЗНАЧЕНИЯ ИЗ ХЭШ-ТАБЛИЦЫ...]" + "\n" + "\n");
                            Console.Write("Введите значение: " + "\n");
                            string value = (Console.ReadLine());
                            hashTable.DeleteElementOfHashTable(value);
                            Console.WriteLine($"\"{value}\" было удалено" + "\n");
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.Write("[ПРОВЕРЯЕМ ЗНАЧЕНИЕ НА ПРИНАДЛЕЖНОСТЬ...]" + "\n" + "\n");
                            Console.Write("Введите значение: " + "\n");
                            string value = (Console.ReadLine());
                            if (hashTable.IsContainInHashTable(value) == true)
                            {
                                Console.WriteLine($"Значение \"{value}\" существует" + "\n");
                            }
                            else
                            {
                                Console.WriteLine($"Значение \"{value}\" не существует" + "\n");
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Выберите вариант реализации хэш - функции (1 - 3)");
                            int count = -1;
                            try
                            {
                                count = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.Clear();
                            }
                            switch (count)
                            {
                                case 1:
                                    {
                                        myHash = new FirstHash();
                                        hashTable.ChangeHash(myHash);
                                        Console.WriteLine($"Вы выбрали {count} реализацию");
                                        break;
                                    }
                                case 2:
                                    {
                                        myHash = new SecondHash();
                                        hashTable.ChangeHash(myHash);
                                        Console.WriteLine($"Вы выбрали {count} реализацию");
                                        break;
                                    }
                                case 3:
                                    {
                                        myHash = new ThirdHash();
                                        hashTable.ChangeHash(myHash);
                                        Console.WriteLine($"Вы выбрали {count} реализацию");
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Такой реализации не существует");
                                        break;
                                    }
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Program.PrintMenu();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Я не знаю такой команды" + "\n");
                            break;
                        }
                }
            }
        }
    }
}
