using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2
{
    static class Degree
    {
        /// <summary>
        /// Makes the hash function more random
        /// </summary>
        /// <param name="degree">Degree of received number</param>
        /// <returns>Returns the power of a number</returns>
        public static int PowerOfTwo(int degree)
        {
            int result = 1;
            for (int i = 0; i != degree; ++i)
            {
                result *= 2;
            }
            return result;
        }
    }
}
