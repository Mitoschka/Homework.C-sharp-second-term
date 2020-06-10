using System.Collections;
using NUnit.Framework;

namespace Task_3._2.Test
{
    class HashTests
    {
        [TestCaseSource(typeof(Hashes))]
        public void AddElementToHashTableAndIsContainInHashTableShouldWork(HashTable hashTable)
        {
            hashTable.AddElementToHashTable("abc");

            Assert.IsTrue(hashTable.IsContainInHashTable("abc"));
        }

        [TestCaseSource(typeof(Hashes))]
        public void AddElementToHashTableAndDeleteElementOfHashTableShouldWork(HashTable hashTable)
        {
            hashTable.AddElementToHashTable("abc");
            hashTable.AddElementToHashTable("ver");
            hashTable.DeleteElementOfHashTable("abc");

            Assert.IsFalse(hashTable.IsContainInHashTable("abc"));
        }

        [TestCaseSource(typeof(Hashes))]
        public void HashTableShouldWorkIfWeTryDeleteEmtyHashTable(HashTable hashTable)
        {
            Assert.Throws<System.InvalidOperationException>(() => hashTable.DeleteElementOfHashTable("dog"));
        }

        [TestCaseSource(typeof(Hashes))]
        public void AddElementToHashTableShouldWorkCorrect(HashTable hashTable)
        {
            hashTable.AddElementToHashTable("abc");
            hashTable.AddElementToHashTable("ver");
            hashTable.AddElementToHashTable("ahc");

            Assert.IsTrue(hashTable.IsContainInHashTable("abc"));
            Assert.IsTrue(hashTable.IsContainInHashTable("ver"));
            Assert.IsTrue(hashTable.IsContainInHashTable("ahc"));

        }

        class Hashes : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new HashTable(new FirstHash());
                yield return new HashTable(new SecondHash());
                yield return new HashTable(new ThirdHash());
            }
        }
    }
}
