using System;

namespace Task_2._2
{
    public class HashTable
    {
        public HashTable()
        {
            for (int i = 0; i != capacity; ++i)
            {
                hashTable[i] = new MyList();
            }
        }

        const int capacity = 100;
        MyList[] hashTable = new MyList[capacity];

        /// <summary>
        /// Makes the hash function more random
        /// </summary>
        /// <param name="degree">Degree of received number</param>
        /// <returns>Returns the power of a number</returns>
        public int PowerOfTwo(int degree)
        {
            int result = 1;
            for (int i = 0; i != degree; ++i)
            {
                result *= 2;
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
                result = (result + PowerOfTwo(i) * value[i]) % capacity;
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
            hashTable[index].AddUniqueElementToList(value);
        }

        /// <summary>
        /// Checks the existence of a value in a hash table
        /// </summary>
        /// <param name="value">Value entered</param>
        /// <returns>Returns index position</returns>
        public bool IsContainInHashTable(string value)
        {
            int index = HashFunction(value);
            return hashTable[index].IsContain(value);
        }

        /// <summary>
        /// Delete the value in the hash table
        /// </summary>
        /// <param name="value">Value to be deleted</param>
        public void DeleteElementOfHashTable(string value)
        {
            int index = HashFunction(value);
            if (IsContainInHashTable(value) == true)
            {
                hashTable[index].DeleteElement(value);
                Console.WriteLine($"\"{value}\" было удалено" + "\n");
            }
            else
            {
                Console.WriteLine("Такого элемента здесь нет");
                return;
            }
        }
    }
}