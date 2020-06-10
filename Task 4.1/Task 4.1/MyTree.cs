using System;

/// <summary>
/// Global namespace.
/// </summary>
namespace Task_4._1
{
    /// <summary>
    /// Class with implementation of MyTree.
    /// </summary>
    public class MyTree
    {
        private ITreeElement head;

        private bool IsOperator(char value) => value == '+' || value == '-' || value == '*' || value == '/';

        private bool IsNumber(char value) => value >= '0' && value <= '9';

        /// <summary>
        /// Adds an element to the tree but not to the head
        /// </summary>
        void AddElementNotToHead(Operator cursor, ITreeElement newElement, ref bool isElementAdded)
        {
            if (cursor == null)
            {
                throw new InvalidOperationException("Error");
            }
            if (!isElementAdded)
            {
                if (cursor.Left == null)
                {
                    cursor.Left = newElement;
                    isElementAdded = true;
                    return;
                }
                if (cursor.Left is Operator)
                {
                    AddElementNotToHead(cursor.Left as Operator, newElement, ref isElementAdded);
                }
            }
            if (!isElementAdded)
            {
                if (cursor.Right == null)
                {
                    cursor.Right = newElement;
                    isElementAdded = true;
                    return;
                }
                if (cursor.Right is Operator)
                {
                    AddElementNotToHead(cursor.Right as Operator, newElement, ref isElementAdded);
                }
            }
        }

        /// <summary>
        /// Adds an element to the tree
        /// </summary>
        void AddElementInTree(ITreeElement newElement)
        {
            if (head == null)
            {
                head = newElement;
                return;
            }

            bool addedElement = false;
            AddElementNotToHead(head as Operator, newElement, ref addedElement);
        }

        /// <summary>
        /// Prints a tree element
        /// </summary>
        void PrintTreeElement(ITreeElement currentElement)
        {
            if (currentElement is Operator && (currentElement as Operator).Left != null)
            {
                Console.Write("( ");
                PrintTreeElement((currentElement as Operator).Left);
            }

            currentElement.Print();
            Console.Write(" ");

            if (currentElement is Operator && (currentElement as Operator).Right != null)
            {
                PrintTreeElement((currentElement as Operator).Right);
                Console.Write(") ");
            }
        }

        /// <summary>
        /// Prints tree
        /// </summary>
        public void PrintTree()
        {
            if (head == null)
            {
                Console.WriteLine("Нет головы.");
                return;
            }
            PrintTreeElement(head as Operator);
        }

        /// <summary>
        /// Puts value in a tree
        /// </summary>
        /// <param name="expression"></param>
        public void PutExpressionToTree(string expression)
        {
            if (expression.Length == 1)
            {
                throw new InvalidOperationException("Error");
            }

            for (int i = 0; i != expression.Length; ++i)
            {
                char element = expression[i];
                if (IsOperator(element))
                {
                    Operator newOperator = element switch
                    {
                        '+' => new Addition(),
                        '/' => new Division(),
                        '*' => new Multiplication(),
                        '-' => new Subtraction(),
                         _ => throw new ArgumentException(),
                    };
                    AddElementInTree(newOperator);
                }

                else if (IsNumber(element))
                {
                    var newElement = new Operand(element);

                    AddElementInTree(newElement);
                }
            }
            if (expression.Length == 0)
            {
                throw new NullException("Файл оказался пуст");
            }
        }

        /// <summary>
        /// Counter values ​​in the tree
        /// </summary>
        /// <returns></returns>
        public int CountExpression() => head.Count();

    }
}