namespace Task_3._2
{
    public class SecondHash : IMyHash
    {
        /// <summary>
        /// Makes the hash function more random
        /// </summary>
        /// <param name="degree">Degree of received number</param>
        /// <returns>Returns the power of a number</returns>
        public int PowerOfThree(int degree)
        {
            int result = 1;
            for (int i = 0; i != degree; ++i)
            {
                result *= 3;
            }

            return result;
        }

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
                result = (result + PowerOfThree(i) * value[i]);
            }

            return result;
        }
    }
}
