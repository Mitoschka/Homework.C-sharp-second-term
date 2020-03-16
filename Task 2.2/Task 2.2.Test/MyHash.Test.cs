using NUnit.Framework;

namespace Task_2._2.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PowerOfTwoShouldWork()
        {
            HashTable hashTable = new HashTable();

            Assert.AreEqual(8, hashTable.PowerOfTwo(3));
        }

        [Test]
        public void AddElementToHashTableAndIsContainInHashTableShouldWork()
        {
            HashTable hashTable = new HashTable();

            hashTable.AddElementToHashTable("abc");

            Assert.IsTrue(hashTable.IsContainInHashTable("abc"));
        }

        [Test]
        public void AddElementToHashTableAndDeleteElementOfHashTableShouldWork()
        {
            HashTable hashTable = new HashTable();

            hashTable.AddElementToHashTable("abc");
            hashTable.AddElementToHashTable("ver");
            hashTable.DeleteElementOfHashTable("abc");

            Assert.IsFalse(hashTable.IsContainInHashTable("abc"));
        }
    }
}