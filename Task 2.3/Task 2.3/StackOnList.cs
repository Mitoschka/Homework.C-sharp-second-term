using System;

namespace Task_2._3
{
    /// <summary>
    /// Stack on List
    /// </summary>
    public class StackOnList : IStack
    {
       private int counter = 0;
       private MyList list = new MyList();

        /// <summary>
        /// The operation to insert a new item.
        /// </summary>
        /// <param name="value"> value of new item </param>
        public void Push(int value)
        {
            list.AddElement(value);
            counter++;
            return;
        }

        /// <summary>
        /// Returns the top element of the stack.
        /// </summary>
        /// <returns> top element </returns>
        public int Pop()
        {
            if (Count() <= 0)
            {
                throw new MyException("The stack is empty");
            }
            else
            {
                counter--;
                return list.RemoveElement();
            }
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
