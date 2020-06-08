using System;

/// <summary>
/// Global namespace.
/// </summary>
namespace Task_4._1
{
    class Subtraction : Operator
    {
        /// <summary>
        /// Element count
        /// </summary>
        public override int Count()
        {
            if (Left == null || Right == null)
            {
                throw new System.InvalidOperationException("Error");
            }
            return Left.Count() - Right.Count();
        }

        /// <summary>
        /// Print value
        /// </summary>
        public override void Print()
        {
            Console.Write("-");
        }
    }
}