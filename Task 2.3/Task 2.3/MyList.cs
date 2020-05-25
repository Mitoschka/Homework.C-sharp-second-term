using System;

/// <summary>
/// Global namespace.
/// </summary>
namespace Task_2._3
{
    public class MyList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyList"/> class.
        /// </summary>
        private class ListElement
        {
            internal int value;
            internal ListElement next;

            /// <summary>
            /// <see cref="ListElement"/> class constructor
            /// </summary>
            /// <param name="value"></param>
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
            newElement.next = currentElement.next;
            currentElement.next = newElement;
            ++counter;
        }

        /// <summary>
        /// Remove element in the List
        /// </summary>
        /// <returns> Result of value </returns>
        public int RemoveElement()
        {
            ListElement currentElement = head;

            if (head == null)
            {
                throw new InvalidOperationException("The list is empty");
            }

            if (currentElement.next == null)
            {
                int firstValue = currentElement.value;
                head = null;
                counter--;
                return firstValue;
            }

            while (currentElement.next.next != null)
            {
                currentElement = currentElement.next;
            }
            int secondValue = currentElement.next.value;
            currentElement.next = null;
            counter--;
            return secondValue;
        }

        /// <summary>
        /// Size of list
        /// </summary>
        /// <returns> Size of list </returns>
        public int SizeOfList() => counter;
    }
}

