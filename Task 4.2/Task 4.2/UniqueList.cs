namespace Task_4._2
{
    /// <summary>
    /// List with unique elements.
    /// </summary>
    public class UniqueList : MyList
    {
        public bool ChecksForUniquenessOfElmenetInList(string value, int position)
        {
            if (position > SizeOfList())
            {
                throw new System.ArgumentOutOfRangeException("Error: Неверно указана позиция");
            }
            if (currentElement == null)
            {
                return true;
            }
            while (currentElement.Next != null)
            {
                if (currentElement.Value == value)
                {
                    throw new AddException($"Выражение {value} не являеться уникальным.");
                }
                currentElement = currentElement.Next;
            }

            if (currentElement.Value != value)
            {
                currentElement.Next = new ListElement(value, currentElement.Next);
                currentElement.Next.Value = value;
                ++Сounter;
            }
            throw new AddException($"Выражение {value} не являеться уникальным.");
        }


        /// <summary>
        /// Adds element to position in list.
        /// </summary>
        /// <param name="value">Element to add.</param>
        /// <param name="position">Position of new element in list.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Throws at the wrong position.</exception>
        /// <exception cref="AddException">Throws when element already exist.</exception>
        public override void AddElement(string value, int position)
        {
            if (!ChecksForUniquenessOfElmenetInList(value, position))
            {
                throw new AddException($"Выражение {value} не являеться уникальным.");
            }
            else
            {
               base.AddElement(value, position);
            }
        }
    }
}
