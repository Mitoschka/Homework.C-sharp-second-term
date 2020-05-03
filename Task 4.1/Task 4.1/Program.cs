using System;
using System.IO;

namespace Task_4._1
{
    class Program
    {
        static void Main()
        {
            MyTree myTree = new MyTree();
            string expression = File.ReadAllText("expression.txt");
            Console.WriteLine($"Исходная строка: {expression}" + "\n");
            myTree.PutExpressionToTree(expression);
            Console.Write("Преобразованная строка: ");
            myTree.PrintTree();
            int result = myTree.CountExpression();
            Console.Write("\n\n" + $"Результат выражения: {result}" + "\n");
        }
    }
}
