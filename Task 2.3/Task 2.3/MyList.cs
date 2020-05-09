using System;

namespace Task_2._3
{
    public class MyList
    {
        private class ListElement
        {
            internal int value;
            internal ListElement next;

            public ListElement(int value)
            {
                this.value = value;
            }
        }

        private ListElement tail;
        private ListElement head;
        private int counter;

        /// <summary>
        /// Add item to List
        /// </summary>
        /// <param name="value">Value to add</param>
        public void AddElement(int value)
        {
            var newElement = new ListElement(value)
            {
                value = value
            };
            if (head == null)
            {
                head = newElement;
                tail = newElement;
                ++counter;
                return;
            }
            tail.next = newElement;
            tail = newElement;
            ++counter;
        }

        /// <summary>
        /// Remove element in the List
        /// </summary>
        /// <returns> Result of value </returns>
        public int RemoveElement()
        {
            ListElement currentElement = head;

            if ((head == null) && (tail == null))
            {
                throw new InvalidOperationException("The list is empty");
            }

            if (currentElement.next == null)
            {
                int firstValue = currentElement.value;
                head = null;
                tail = null;
                counter--;
                return firstValue;
            }

            while (currentElement.next.next != null)
            {
                currentElement = currentElement.next;
            }
            int secondValue = currentElement.next.value;
            currentElement.next = null;
            tail = currentElement;
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

