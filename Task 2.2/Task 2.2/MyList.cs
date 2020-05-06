using System;

namespace Task_2._2
{
    public class MyList
    {
        private class ListElement
        {
            internal string value;
            internal ListElement next;

            public ListElement(string value)
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
        public void AddElement(string value)
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
            if (head.next == null)
            {
                head.next = tail;
                tail.next = newElement;
                tail = newElement;
                ++counter;
                return;
            }
            tail.next = newElement;
            tail = newElement;
            ++counter;
        }

        /// <summary>
        /// Delete the value in the List
        /// </summary>
        /// <param name="value">Value to be deleted</param>
        public void DeleteElement(string value)
        {
            ListElement currentElement = head;
            if (currentElement == null)
            {
                throw new NullReferenceException("Нет начала списка");
            }
            if (head.value == value)
            {
                head = currentElement.next;
                --counter;
                return;
            }
            while (currentElement.next != null && currentElement.next.value != value)
            {
                currentElement = currentElement.next;
            }
            currentElement.next = currentElement.next.next;
            --counter;
        }

        /// <summary>
        /// Checks the existence of a value in a List
        /// </summary>
        /// <param name="value">Value entered</param>
        /// <returns>Returns check result</returns>
        public bool Contains(string value)
        {
            ListElement currentElement = head;
            while (currentElement != null)
            {
                if (value == currentElement.value)
                {
                    return true;
                }
                currentElement = currentElement.next;
            }
            return false;
        }

        /// <summary>
        /// Add a unique item to List
        /// </summary>
        /// <param name="value">Unique value</param>
        public bool AddUniqueElementToList(string value)
        {
            if (head == null)
            {
                head = new ListElement(value)
                {
                    value = value
                };
                ++counter;
                return true;
            }

            ListElement currentElement = head;
            while (currentElement.next != null)
            {
                if (currentElement.value == value)
                {
                    return false;
                }
                currentElement = currentElement.next;
            }

            if (currentElement.value != value)
            {
                currentElement.next = new ListElement(value)
                {
                    value = value
                };
                ++counter;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Size of list
        /// </summary>
        public int SizeOfList() => counter;
    }
}