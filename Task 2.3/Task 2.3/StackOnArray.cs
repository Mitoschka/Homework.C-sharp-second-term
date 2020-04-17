using System;

namespace Task_2._3
{
    /// <summary>
    /// Stack on array
    /// </summary>
    public class StackOnArray : IStack
    {
        const int size = 100;

        private int counter = 0;
        private string[] stringArray = new string[size];

        /// <summary>
        /// The operation to insert a new item.
        /// </summary>
        /// <param name="value"> value of new item </param>
        public void Push(string value)
        {
            if (counter > size)
            {
                throw new MyException("Out of bounds array");
            }
            stringArray[counter] = value;
            counter++;
        }

        /// <summary>
        /// Returns the top element of the stack.
        /// </summary>
        /// <returns> top element </returns>
        public string Peek()
        {
            if (stringArray[counter] == null)
            {
                string result = stringArray[counter - 1];
                stringArray[counter - 1] = null;
                counter--;
                return result;
            }
            else
            {
                throw new MyException("The stack is empty");
            }
        }

        /// <summary>
        /// Returns the number of items on the stack.
        /// </summary>
        /// <returns> size of stack </returns>
        public int Count()
        {
            if (counter == 0)
            {
                throw new MyException("The stack is empty");
            }
            else
            {
                return counter;
            }
        }
    }
}
