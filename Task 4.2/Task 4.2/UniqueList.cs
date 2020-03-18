using System;

namespace MyList
{
    public class UniqueList : MyList
    {
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
                    throw new AddException("Error: Выражение не являеться уникальным");
                }
                currentElement = currentElement.next;
            }

            if (currentElement.value != value)
            {
                currentElement.next = new ListElement();
                currentElement.next.value = value;
                ++counter;
            }
            throw new AddException("Error: Выражение не являеться уникальным");
        }
    }
}
