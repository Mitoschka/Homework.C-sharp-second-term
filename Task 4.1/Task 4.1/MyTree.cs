using System;

namespace Task_4._1
{
    public class MyTree
    {

        ITreeElement head;

        bool IsOperator(char value)
        {
            return value == '+' || value == '-' || value == '*' || value == '/';
        }

        bool IsNumber(char value)
        {
            return value >= '0' && value <= '9';
        }

        void AddElementNotToHead(Operator currentElement, ITreeElement newElement, ref bool isElementAdded)
        {
            if (!isElementAdded)
            {
                if (currentElement.Left == null)
                {
                    currentElement.Left = newElement;
                    isElementAdded = true;
                    return;
                }
                if (IsOperator(currentElement.Left.Value))
                {
                    AddElementNotToHead(currentElement.Left, newElement, ref isElementAdded);
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
                if (IsOperator(currentElement.Right.Value))
                {
                    AddElementNotToHead(currentElement.Right, newElement, ref isElementAdded);
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

            ITreeElement currentElement = head;
            bool addedElement = false;
            AddElementNotToHead(currentElement, newElement, ref addedElement);
        }

        void PrintTreeElement(ITreeElement currentElement)
        {
            if (currentElement.Left != null)
            {
                if (IsOperator(currentElement.Value))
                {
                    Console.Write("( ");
                }
                PrintTreeElement(currentElement.Left);
            }

            currentElement.Print();
            Console.Write(" ");

            if (currentElement.Right != null)
            {
                PrintTreeElement(currentElement.Right);
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
            PrintTreeElement(head);
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
