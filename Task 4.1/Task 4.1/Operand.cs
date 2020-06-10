using System;

/// <summary>
/// Global namespace.
/// </summary>
namespace Task_4._1
{
    /// <summary>
    /// Class with implementation of Operand.
    /// </summary>
    class Operand : ITreeElement
    {
        /// <summary>
        /// <see cref="Operand"/> class constructor
        /// </summary>
        public Operand(char value)
        {
            valueElement = value;
        }

        private char valueElement;
        
        public char Value
        {
            get => valueElement;
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
        public int Count() => Value - '0';
    }
}