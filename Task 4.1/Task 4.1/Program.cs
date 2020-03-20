using System;
using System.IO;

namespace Task_4._1
{
    class Program
    {
        static void Main()
        {
            MyTree myTree = new MyTree();
            FileStream file = new FileStream("C:\\Users\\Admin\\Desktop\\Task 4.1\\expression.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string expression = reader.ReadLine();
            Console.WriteLine($"Исходная строка: {expression}" + "\n");
            myTree.PutExpressionToTree(expression);
            Console.Write("Преобразованная строка: ");
            myTree.PrintTree();
            int result = myTree.CountExpression();
            Console.Write("\n\n" + $"Результат выражения: {result}" + "\n");
            reader.Close();
        }
    }
}
