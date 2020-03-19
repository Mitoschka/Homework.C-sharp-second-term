using System;

namespace MyList
{
    /// <summary>
    /// Add item to list
    /// </summary>
    /// <param name="value">Value to add</param>
    /// <param name="position">Number of item to add value to</param>
    public class MyList
    {
        public class ListElement
        {
            public string value;
            public ListElement next;
        }

        public ListElement head;
        public int counter;

        /// <summary>
        /// Add item to List
        /// </summary>
        /// <param name="value">Value to add</param>
        public void AddElement(string value)
        {
            ListElement newElement = new ListElement();
            newElement.value = value;
            if (head == null)
            {
                head = newElement;
                ++counter;
                return;
            }
            ListElement currentElement = head;
            while (currentElement.next != null)
            {
                currentElement = currentElement.next;
            }
            newElement.next = currentElement.next;
            currentElement.next = newElement;
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
                throw new DeleteException("Error: Отсутствует начало списка");
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
            if (currentElement.next == null)
            {
                throw new DeleteException("Error: Такого элемента нет");
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