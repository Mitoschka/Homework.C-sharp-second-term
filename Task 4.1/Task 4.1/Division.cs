using System;

/// <summary>
/// Global namespace.
/// </summary>
namespace Task_4._1
{
    class Division : Operator
    {
        /// <summary>
        /// Element count
        /// </summary>
        public override int Count()
        {
            return Left.Count() / Right.Count();
        }

        /// <summary>
        /// Print value
        /// </summary>
        public override void Print()
        {
            Console.Write("/");
        }
    }
}