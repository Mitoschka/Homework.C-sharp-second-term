using System;

namespace Task_2._3
{
    /// <summary>
    /// Stack on array
    /// </summary>
    public class StackOnArray : IStack
    {
        private static int size = 100;

        private int counter = 0;
        private int[] stringArray = new int[size];

        /// <summary>
        /// The operation to insert a new item.
        /// </summary>
        /// <param name="value"> value of new item </param>
        public void Push(int value)
        {
            if (counter >= size)
            {
                Array.Resize(ref stringArray, stringArray.Length * 2);
            }
            stringArray[counter] = value;
            counter++;
        }

        /// <summary>
        /// Returns the top element of the stack.
        /// </summary>
        /// <returns> top element </returns>
        public int Pop()
        {
            if (stringArray[counter] == 0)
            {
                try
                {
                    int result = stringArray[counter - 1];
                    stringArray[counter - 1] = 0;
                    counter--;
                    return result;
                }
                catch
                {
                    throw new MyException("The stack is empty");
                }
            }
            return 0;
        }

        /// <summary>
        /// Returns the number of items on the stack.
        /// </summary>
        /// <returns> size of stack </returns>
        public int Count()
        {
            return counter;
        }
    }
}
