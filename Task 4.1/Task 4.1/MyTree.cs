using System;

namespace Task_4._1
{
    public class MyTree
    {
        private ITreeElement head;
        private Operator currentElement;

        private bool IsOperator(char value) => value == '+' || value == '-' || value == '*' || value == '/';

        private bool IsNumber(char value) => value >= '0' && value <= '9';

        void AddElementNotToHead(ITreeElement newElement, ref bool isElementAdded)
        {
            if (!isElementAdded)
            {
                if (currentElement.Left == null)
                {
                    currentElement.Left = newElement;
                    isElementAdded = true;
                    return;
                }
                if (currentElement.Left is Operator)
                // if (currentElement.Left -- это класс Operator??)
                {
                    AddElementNotToHead(newElement, ref isElementAdded);
                }
            }
            if (!isElementAdded)
            {
                if (currentElement.Right == null)
                {
                    currentElement.Right = newElement;
                    isElementAdded = true;
                    return;
                }
                if (currentElement.Right is Operator)
                {
                    AddElementNotToHead(newElement, ref isElementAdded);
                }
            }
        }

        void AddElementInTree(ITreeElement newElement)
        {
            if (head == null)
            {
                head = newElement;
                return;
            }

            bool addedElement = false;
            AddElementNotToHead(newElement, ref addedElement);
        }

        void PrintTreeElement(Operator currentElement)
        {
            if (currentElement.Left != null)
            {
                if (currentElement is Operator)
                {
                    Console.Write("( ");
                }
                PrintTreeElement(currentElement);
            }

            currentElement.Print();
            Console.Write(" ");

            if (currentElement.Right != null)
            {
                PrintTreeElement(currentElement);
                Console.Write(") ");
            }
        }

        public void PrintTree()
        {
            if (head == null)
            {
                Console.WriteLine("Нет головы.");
                return;
            }
            PrintTreeElement(currentElement);
        }

        public void PutExpressionToTree(string expression)
        {
            for (int i = 0; i != expression.Length; ++i)
            {
                char element = expression[i];
                if (IsOperator(element))
                {
                    Operator newElement = new Operator();
                    newElement.Value = element;

                    AddElementInTree(newElement);
                }
                else if (IsNumber(element))
                {
                    Operand newElement = new Operand();
                    newElement.Value = element;

                    AddElementInTree(newElement);
                }
            }
            if (expression.Length == 0)
            {
                throw new NullException("Файл оказался пуст");
            }
        }

        public int CountExpression()
        {
            return head.Count();
        }
    }
}
