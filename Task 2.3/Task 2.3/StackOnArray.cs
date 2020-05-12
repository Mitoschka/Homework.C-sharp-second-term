using System;

/// <summary>
/// Global namespace.
/// </summary>
namespace Task_2._3
{
    /// <summary>
    /// Stack on array
    /// </summary>
    public class StackOnArray : IStack
    {
        private int counter = 0;
        private int[] intArray = new int[100];

        /// <summary>
        /// The operation to insert a new item.
        /// </summary>
        /// <param name="value"> value of new item </param>
        public void Push(int value)
        {
            if (counter >= intArray.Length)
            {
                Array.Resize(ref intArray, intArray.Length * 2);
            }
            intArray[counter] = value;
            counter++;
        }

        /// <summary>
        /// Returns and Delete the top element of the stack.
        /// </summary>
        /// <returns> top element </returns>
        public int Pop()
        {
            if (counter <= 0)
            {
                throw new System.InvalidOperationException("The stack is empty");
            }
            else
            {
                int result = intArray[counter - 1];
                intArray[counter - 1] = 0;
                counter--;
                return result;
            }
        }

        /// <summary>
        /// Returns the number of items on the stack.
        /// </summary>
        /// <returns> size of stack </returns>
        public int Count() => counter;
    }
}
