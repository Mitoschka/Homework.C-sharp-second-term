using System;

/// <summary>
/// Global namespace.
/// </summary>
namespace Task_4._1
{
    /// <summary>
    /// Class with implementation of Operator.
    /// </summary>
    abstract class Operator : ITreeElement
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

        /// <summary>
        /// Prints the value of an operator
        /// </summary>
        public abstract void Print();

        /// <summary>
        /// The counter of operators in a tree
        /// </summary>
        public abstract int Count();
    }
}