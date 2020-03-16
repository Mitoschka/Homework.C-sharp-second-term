using System;

namespace Task_2._2
{
    public class MyList
    {
        class ListElement
        {
            internal string value;
            internal ListElement next;
        }

        ListElement head;
        int counter;

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
                Console.WriteLine("Нет начала списка");
                --counter;
                return;
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
                head = new ListElement();
                head.value = value;
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
                currentElement.next = new ListElement();
                currentElement.next.value = value;
                ++counter;
            }
        }

        public int SizeOfList()
        {
            return counter;
        }
    }
}