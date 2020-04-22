namespace Task_4._2
{
    /// <summary>
    /// List with unique elements.
    /// </summary>
    public class UniqueList : MyList
    {
        /// <summary>
        /// Adds element to position in list.
        /// </summary>
        /// <param name="value">Element to add.</param>
        /// <param name="position">Position of new element in list.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Throws at the wrong position.</exception>
        /// <exception cref="AddException">Throws when element already exist.</exception>
        public void AddUniqueElement(string value, int position)
        {
            if (AddUniqueElementToList(value, position))
            {
                throw new AddException($"Element {value} already exist.");
            }
            else
            {
                AddElement(value, position);
            }
        }
    }
}
