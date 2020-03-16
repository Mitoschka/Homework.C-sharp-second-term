namespace Task_3._2
{
    public class FirstHash : IMyHash
    {
        const int capacity = 100;

        /// <summary>
        /// Transforming an array of input data into a bit string of a specified length
        /// </summary>
        /// <param name="value">Input value</param>
        /// <returns>Returns result</returns>
        public int HashFunction(string value)
        {
            int result = 0;
            for (int i = 0; i != value.Length; ++i)
            {
                result = (result * value[i]) % capacity;
            }

            return result;
        }
    }
}
