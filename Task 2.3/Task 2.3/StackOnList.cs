using System;

namespace Task_2._3
{
    /// <summary>
    /// Stack on List
    /// </summary>
    public class StackOnList : IStack
    {
        int counter = 0;
        MyList list = new MyList();

        /// <summary>
        /// The operation to insert a new item.
        /// </summary>
        /// <param name="value"> value of new item </param>
        public void Push(string value)
        {
            list.AddElement(value);
            counter++;
            return;
        }

        /// <summary>
        /// Returns the top element of the stack.
        /// </summary>
        /// <returns> top element </returns>
        public string Peek()
        {
            counter--;
            return list.RemoveElement();
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
