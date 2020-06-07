using System;

/// <summary>
/// Global namespace.
/// </summary>
namespace Task_4._1
{
    class Operand : ITreeElement
    {
        private char valueElement;
        
        public char Value
        {
            get => valueElement;
            set => valueElement = value;
        }

        /// <summary>
        /// Prints the value of an operand
        /// </summary>
        public void Print()
        {
            Console.Write($"{Value}");
        }

        /// <summary>
        /// The counter of operands in a tree
        /// </summary>
        public int Count()
        {
            return Value - '0';
        }
    }
}