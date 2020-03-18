using System;

namespace Task_4._2
{
    public class UniqueList : MyList.MyList
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
    }
}
