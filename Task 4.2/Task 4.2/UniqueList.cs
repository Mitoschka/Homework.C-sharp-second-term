/// <summary>
/// Global namespace.
/// </summary>
namespace Task_4._2
{
    /// <summary>
    /// List with unique elements.
    /// </summary>
    public class UniqueList : MyList
    {
        /// <summary>
        /// Adds element to position in MyList.
        /// </summary>
        /// <param name="value">Element to add.</param>
        /// <param name="position">Position of new element in list.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Throws at the wrong position.</exception>
        /// <exception cref="AddException">Throws when element already exist.</exception>
        public override void AddElement(string value, int position)
        {
            if (IsContain(value))
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
