using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4._1
{
    class Operand : ITreeElement
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
            return Value - '0';
        }
    }
}
