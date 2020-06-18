using System;

/// <summary>
/// Global namespace.
/// </summary>
namespace Task_3._2
{
    /// <summary>
    /// Class with implementation of HashTable.
    /// </summary>
    public class HashTable
    {
        /// <summary>
        /// Represents a collection of key-value pairs that are ordered by a key hash.
        /// </summary>
        /// <param name="myHash"> Class instance, its interface </param>
        public HashTable(IMyHash myHash)
        {
            Hash = myHash;
            for (int i = 0; i != capacity; ++i)
            {
                hashTable[i] = new MyList();
            }
        }

        private IMyHash Hash;
        private const int capacity = 100;
        private MyList[] hashTable = new MyList[capacity];

        /// <summary>
        /// Change my hash
        /// </summary>
        /// <param name="myHash"> changed hash </param>
        public void ChangeHash(IMyHash myHash)
        {
            var list = new MyList();
            for (int i = 0; i < capacity; i++)
            {
                while (hashTable[i].SizeOfList() != 0)
                {
                    string value = hashTable[i].PopElement();
                    list.AddElement(value);
                }
            }
            Hash = myHash;
            while (list.SizeOfList() != 0)
            {
                string value = list.PopElement();
                AddElementToHashTable(value);
            }
        }

        /// <summary>
        /// Add value to hash table and checks value for uniqueness in hash table
        /// </summary>
        /// <param name="value">Value to add</param>
        public void AddElementToHashTable(string value)
        {
            int index = Math.Abs(Hash.HashFunction(value) % capacity);
            hashTable[index].AddUniqueElementToList(value);
        }

        /// <summary>
        /// Checks the existence of a value in a hash table
        /// </summary>
        /// <param name="value">Value entered</param>
        /// <returns>Returns index position</returns>
        public bool IsContainInHashTable(string value)
        {
            int index = Math.Abs(Hash.HashFunction(value) % capacity);
            return hashTable[index].IsContain(value);
        }

        /// <summary>
        /// Delete the value in the hash table
        /// </summary>
        /// <param name="value">Value to be deleted</param>
        public void DeleteElementOfHashTable(string value)
        {
            if (IsContainInHashTable(value))
            {
                int index = Math.Abs(Hash.HashFunction(value) % capacity);
                hashTable[index].DeleteElement(value);
            }
            else
            {
                throw new InvalidOperationException("Такого элемента здесь нет");
            }
        }
    }
}
