using System;

/// <summary>
/// Global namespace.
/// </summary>
namespace Task_2._3
{
    /// <summary>
    /// Custom implementation of List
    /// </summary>
    public class MyList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListElement"/> class.
        /// </summary>
        private class ListElement
        {
            internal int value;
            internal ListElement next;

            /// <summary>
            /// <see cref="ListElement"/> class constructor
            /// </summary>
            public ListElement(int value)
            {
                this.value = value;
            }
        }

        private ListElement head;
        private int counter;

        /// <summary>
        /// Add item to List
        /// </summary>
        /// <param name="value">Value to add</param>
        public void AddElement(int value)
        {
            var newElement = new ListElement(value);
            if (head == null)
            {
                head = newElement;
                ++counter;
                return;
            }
            ListElement currentElement = head;
            newElement.next = currentElement;
            head = newElement;
            ++counter;
        }

        /// <summary>
        /// Remove element in the List
        /// </summary>
        /// <returns> Result of value </returns>
        public int RemoveElement()
        {
            if (head == null)
            {
                throw new InvalidOperationException("The list is empty");
            }

            int value = head.value;
            head = head.next;
            counter--;
            return value;
        }

        /// <summary>
        /// Size of list
        /// </summary>
        /// <returns> Size of list </returns>
        public int SizeOfList() => counter;
    }
}

