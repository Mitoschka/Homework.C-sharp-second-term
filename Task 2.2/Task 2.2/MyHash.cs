using System;

namespace Task_2._2
{
    /// <summary>
    /// Custom implementation of Hash table
    /// </summary>
    public class HashTable
    {
        public HashTable()
        {
            for (int i = 0; i != capacity; ++i)
            {
                hashTable[i] = new MyList();
            }
        }

        private const int capacity = 100;
        private MyList[] hashTable = new MyList[capacity];
        private int count = 0;

        /// <summary>
        /// Transforming an array of input data into a bit string of a specified length
        /// </summary>
        /// <param name="value">Input value</param>
        /// <returns>Returns result</returns>
        private int HashFunction(string value)
        {
            int result = 0;
            for (int i = 0; i != value.Length; ++i)
            {
                result = (result + Degree.PowerOfTwo(i) * value[i]) % capacity;
            }
            return result;
        }

        /// <summary>
        /// Add value to hash table and checks value for uniqueness in hash table
        /// </summary>
        /// <param name="value">Value to add</param>
        public void AddElementToHashTable(string value)
        {
            int index = HashFunction(value);
            if (hashTable[index].AddUniqueElementToList(value))
            {
                count++;
            }
        }

        /// <summary>
        /// Checks the existence of a value in a hash table
        /// </summary>
        /// <param name="value">Value entered</param>
        /// <returns>Returns index position</returns>
        public bool IsContainInHashTable(string value)
        {
            int index = HashFunction(value);
            return hashTable[index].Contains(value);
        }

        /// <summary>
        /// Delete the value in the hash table
        /// </summary>
        /// <param name="value">Value to be deleted</param>
        public void DeleteElementOfHashTable(string value)
        {
            if (IsContainInHashTable(value))
            {
                int index = HashFunction(value);
                hashTable[index].DeleteElement(value);
                count--;
            }
            else
            {
                throw new NullReferenceException("Такого элемента здесь нет");
            }
        }

        /// <summary>
        /// Size of Hash Table
        /// </summary>
        /// <returns> Size of Hash Table </returns>
        public int SizeOfHashTable() => count;
    }
}