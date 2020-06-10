using System;
using System.IO;

/// <summary>
/// Global namespace.
/// </summary>
namespace Task_4._1
{
    /// <summary>
    /// Class with Main function.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main function in program.
        /// </summary>
        /// <param name="args">Program arguments.</param>
        private static void Main(string[] args)
        {
            var myTree = new MyTree();
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
