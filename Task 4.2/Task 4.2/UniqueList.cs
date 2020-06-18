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

        /// <summary>
        /// Cheak element to position in MyList.
        /// </summary>
        /// <param name="position">Position of new element in list.</param>
        /// <param name="stringOfValue">Element to cheack.</param>
        public override void SetItemValue(int position, string stringOfValue)
        {
            if (IsContain(stringOfValue))
            {
                if (GetPositionByElementsValue(stringOfValue) == position)
                {
                    return;
                }
                throw new AddException($"Выражение {stringOfValue} не являеться уникальным.");
            }
            else
            {
                base.SetItemValue(position, stringOfValue);
            }
        }
    }
}
