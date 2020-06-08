using System;

/// <summary>
/// Global namespace.
/// </summary>
namespace Task_3._2
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
            if ((head == null) && (tail == null))
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
        public bool IsContain(string value)
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
        public void AddUniqueElementToList(string value)
        {
            if (head == null)
            {
                head = new ListElement(value)
                {
                    value = value
                };
                ++counter;
                return;
            }

            ListElement currentElement = head;
            while (currentElement.next != null)
            {
                if (currentElement.value == value)
                {
                    return;
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
            }
        }

        /// <summary>
        /// Pop the element
        /// </summary>
        /// <returns> element </returns>
        public string PopElement()
        {
            ListElement currentElement = head;
            if (currentElement == null)
            {
                throw new InvalidOperationException("The list is empty");
            }

            string value;
            if (currentElement.next == null)
            {
                value = currentElement.value;
                head = null;
                counter--;
                return value;
            }

            while (currentElement.next.next != null)
            {
                currentElement = currentElement.next;
            }
            value = currentElement.next.value;
            currentElement.next = null;
            counter--;
            return value;
        }

        /// <summary>
        /// Size of list
        /// </summary>
        /// <returns> Size of list </returns>
        public int SizeOfList()
        {
            return counter;
        }
    }
}
