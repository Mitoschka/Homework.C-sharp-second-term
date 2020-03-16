using System;

namespace MyList
{
    class Program
    {
        static void PrintMenu()
        {
            Console.Write("[МЕНЮ КОМАНД]: \n" +
            "'0' - Выход из программы \n" +
            "'1' - Добавить элемент по произвольной позиции, задаваемой целым числом \n" +
            "'2' - Удалить элемент по произвольной позиции, задаваемой целым числом \n" +
            "'3' - Узнать размер списка \n" +
            "'4' - Получить значение элемента по позиции, задаваемой целым числом \n" +
            "'5' - Устанавливить значение элемента по позиции, задаваемой целым числом \n" +
            "'6' - Вызвать меню команд \n" + "\n");
        }
        static void Main()
        {
            MyList list = new MyList();

            Console.Write("Это программа по работе с листом \n");
            Program.PrintMenu();

            int number = -1;

            while (number != 0)
            {
                Console.Write("\nВведите номер команды: " + "\n");
                Console.Write("'6' - Вызвать меню команд \n" + "\n");
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
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
                            Console.Write("[ДОБАВЛЯЕМ ЭЛЕМЕНТ В СПИСОК...]" + "\n" + "\n");
                            Console.Write("Введите значение числа: " + "\n");
                            int value;
                            try
                            {
                                value = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.Write("\n" + "[НЕКОРРЕКТНЫЙ ВВОД]" + "\n");
                                break;
                            }
                            Console.Write("Введите значение позиции: " + "\n");
                            int position;
                            try
                            {
                                position = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.Write("\n" + "[НЕКОРРЕКТНЫЙ ВВОД]" + "\n");
                                break;
                            }
                            if (position > list.SizeOfList() && position < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Такой позиции не существует");
                                break;
                            }
                            list.AddElement(value, position);
                            Console.Write($"Число {value} было добавлено в {position} позицию" + "\n");
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.Write("[УДАЛЯЕМ ЭЛЕМЕНТ ИЗ СПИСКА...]" + "\n" + "\n");
                            Console.Write("Введите значение позиции: " + "\n");
                            int position;
                            try
                            {
                                position = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.Write("\n" + "[НЕКОРРЕКТНЫЙ ВВОД]" + "\n");
                                break;
                            }
                            list.DeleteElement(position);
                            if (position > list.SizeOfList())
                            {
                                Console.Clear();
                                Console.WriteLine("Такой позиции не существует");
                                break;
                            }
                            Console.Write($"{position} позиция была удалена" + "\n");
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.Write($"Размер листа равен {list.SizeOfList()}" + "\n");
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.Write("[УЗНАЕМ ЗНАЧЕНИЕ ЭЛЕМЕНТА В СПИСКЕ...]" + "\n" + "\n");
                            Console.Write("Введите значение позиции: " + "\n");
                            int position;
                            try
                            {
                                position = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.Write("\n" + "[НЕКОРРЕКТНЫЙ ВВОД]" + "\n");
                                break;
                            }
                            if (position > list.SizeOfList() && position < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Такой позиции не существует");
                                break;
                            }
                            Console.Write($" Значение в позиции {position} = {list.GetItemValue(position)}" + "\n");
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.Write("[ПЕРЕЗАПИСЫВАЕМ ЗНАЧЕНИЕ ЭЛЕМЕНТА В СПИСКЕ...]" + "\n" + "\n");
                            Console.Write("Введите значение позиции: " + "\n");
                            int position;
                            try
                            {
                                position = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.Write("\n" + "[НЕКОРРЕКТНЫЙ ВВОД]" + "\n");
                                break;
                            }
                            Console.Write("Введите число: " + "\n");
                            int numbers;
                            try
                            {
                                numbers = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.Write("\n" + "[НЕКОРРЕКТНЫЙ ВВОД]" + "\n");
                                break;
                            }
                            if (position > list.SizeOfList() && position < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Такой позиции не существует");
                                break;
                            }
                            list.SetItemValue(position, numbers);
                            Console.Write($"Значение в {position} позиции была измененна на число {numbers}" + "\n");
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            Program.PrintMenu();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.Write("Я не знаю такой команды" + "\n");
                            break;
                        }
                }
            }
        }
    }
}