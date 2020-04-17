using NUnit.Framework;

namespace Task_2._2.Test
{
    public class Tests
    {
       private HashTable hashTable;

        [SetUp]
        public void Setup()
        {
            hashTable = new HashTable();
        }

        [Test]
        public void MyExceptionInDeleteElementOfHashTableShouldWork()
        {
            Assert.Throws<MyException>(() => hashTable.DeleteElementOfHashTable("abc"));
        }

        [Test]
        public void AddUniqueElelementToHashTableShouldWork()
        {
            hashTable.AddElementToHashTable("abc");
            hashTable.AddElementToHashTable("abc");
            hashTable.AddElementToHashTable("abc");
            hashTable.AddElementToHashTable("abc");
            hashTable.AddElementToHashTable("vrc");

            Assert.AreEqual(2, hashTable.SizeOfHashTable());
        }

        [Test]
        public void AddUniqueElelementForThousendElementToHashTableShouldWork()
        {
            for (int i = 0; i <= 1000; i++)
            {
                hashTable.AddElementToHashTable("abc");
            }

            Assert.AreEqual(1, hashTable.SizeOfHashTable());
        }

        [Test]
        public void AddElementToHashTableAndIsContainInHashTableShouldWork()
        {
            hashTable.AddElementToHashTable("abc");

            Assert.IsTrue(hashTable.IsContainInHashTable("abc"));
        }

        [Test]
        public void AddElementToHashTableAndDeleteElementOfHashTableShouldWork()
        {
            hashTable.AddElementToHashTable("abc");
            hashTable.AddElementToHashTable("ver");
            hashTable.DeleteElementOfHashTable("abc");

            Assert.IsFalse(hashTable.IsContainInHashTable("abc"));
        }
    }
}