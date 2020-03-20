using System;

namespace Task_4._1
{
    public class Operator : ITreeElement
    {
        private ITreeElement left;
        public ITreeElement Left
        {
            get => left;
            set => left = value;
        }
        private ITreeElement right;
        public ITreeElement Right
        {
            get => right;
            set => right = value;
        }
        private char valueElement;
        public char Value
        {
            get => valueElement;
            set => valueElement = value;
        }
        public void Print()
        {
            Console.Write($"{Value}");
        }
        public int Count()
        {
            switch (Value)
            {
                case '+':
                    {
                        return Left.Count() + Right.Count();
                    }
                case '-':
                    {
                        return Left.Count() - Right.Count();
                    }
                case '*':
                    {
                        return Left.Count() * Right.Count();
                    }
                case '/':
                    {
                        return Left.Count() / Right.Count();
                    }
                default:
                    {
                        return 0;
                    }
            }
        }
    }
}