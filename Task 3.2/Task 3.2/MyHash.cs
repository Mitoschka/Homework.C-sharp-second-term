using System;

namespace Task_3._2
{
    public class HashTable
    {
        /// <summary>
        /// Creat HashTable
        /// </summary>
        /// <param name="myHash"> instance of classe, its auction </param>
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
        private int count = 0;

        /// <summary>
        /// Change my hash
        /// </summary>
        /// <param name="myHash"> changed hash </param>
        public void ChangeHash(IMyHash myHash)
        {
            MyList list = new MyList();
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
            int index = Hash.HashFunction(value) % capacity;
            hashTable[index].AddUniqueElementToList(value);
        }

        /// <summary>
        /// Checks the existence of a value in a hash table
        /// </summary>
        /// <param name="value">Value entered</param>
        /// <returns>Returns index position</returns>
        public bool IsContainInHashTable(string value)
        {
            int index = Hash.HashFunction(value) % capacity;
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
                int index = Hash.HashFunction(value) % capacity;
                hashTable[index].DeleteElement(value);
            }
            else
            {
                throw new InvalidOperationException("Такого элемента здесь нет");
            }
        }
    }
}
