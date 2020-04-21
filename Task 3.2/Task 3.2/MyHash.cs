using System;

namespace Task_3._2
{
    public class HashTable
    {
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
            int index = Hash.HashFunction(value);
            return hashTable[index].IsContain(value);
        }

        /// <summary>
        /// Pop the element
        /// </summary>
        /// <returns> element </returns>
        public string PopElement()
        {
            int index = Hash.HashFunction(hashTable[count].PopElement());
            if (count < capacity)
            {
                count++;
            }
            return hashTable[index].PopElement();
        }

        /// <summary>
        /// Add element to hash table
        /// </summary>
        public void AddElementToHashTable()
        {
            int index = Hash.HashFunction(PopElement());
            hashTable[index].AddUniqueElementToList(PopElement());
        }


        /// <summary>
        /// Delete the value in the hash table
        /// </summary>
        /// <param name="value">Value to be deleted</param>
        public void DeleteElementOfHashTable(string value)
        {
            int index = Hash.HashFunction(value);
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
