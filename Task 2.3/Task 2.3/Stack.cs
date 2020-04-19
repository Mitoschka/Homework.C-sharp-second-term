namespace Task_2._3
{
    /// <summary>
    /// Stack interface
    /// </summary>
    public interface IStack
    {
        /// <summary>
        /// The operation to insert a new item.
        /// </summary>
        /// <param name="value">Value of new item</param> 
        void Push(string value);

        /// <summary>
        /// Returns the top element of the stack.
        /// </summary>
        /// <returns>Top element</returns>
        string Pop();

        /// <summary>
        /// Returns the number of items on the stack.
        /// </summary>
        /// <returns></returns>
        int Count();
    }
}

