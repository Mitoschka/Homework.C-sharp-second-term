using System;

namespace Task_2._2
{
    /// <summary>
    /// Custom implementation of List
    /// </summary>
    public class MyList
    {
        /// <summary>
        /// Sheet element class
        /// </summary>
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
            if ((head == null) && (tail == null))
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
            if ((head == null) && (tail == null))
            {
                throw new NullReferenceException("Нет начала списка");
            }
            if ((head.value == value) && (tail.value == value))
            {
                head = head.next;
                tail = tail.next;
                --counter;
                return;
            }
            while ((head.next != null && head.next.value != value) && (tail.next != null && tail.next.value != value))
            {
                head = head.next;
                tail = tail.next;
            }
            head.next = head.next.next;
            tail.next = tail.next.next;
            --counter;
        }

        /// <summary>
        /// Checks the existence of a value in a List
        /// </summary>
        /// <param name="value">Value entered</param>
        /// <returns>Returns check result</returns>
        public bool Contains(string value)
        {
            while ((head != null) && (tail != null))
            {
                if ((value == head.value) && (value == tail.value))
                {
                    return true;
                }
                head = head.next;
                tail = tail.next;
            }
            return false;
        }

        /// <summary>
        /// Add a unique item to List
        /// </summary>
        /// <param name="value">Unique value</param>
        public bool AddUniqueElementToList(string value)
        {
            if ((head == null) && (tail == null))
            {
                head = new ListElement(value)
                {
                    value = value
                };
                tail = new ListElement(value)
                {
                    value = value
                };
                ++counter;
                return true;
            }

            while ((head.next != null) && (tail.next != null))
            {
                if ((head.value == value) && (tail.value == value))
                {
                    return false;
                }
                head = head.next;
                tail = tail.next;
            }

            if ((head.value != value) && (tail.value != value))
            {
                head = new ListElement(value)
                {
                    value = value
                };
                tail = new ListElement(value)
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