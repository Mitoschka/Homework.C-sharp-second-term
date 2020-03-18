using NUnit.Framework;


namespace Task_3._2.Test
{
    class HashTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddElementToHashTableAndIsContainInHashTableShouldWork()
        {
            IMyHash myHash = new ThirdHash();
            HashTable hashTable = new HashTable(myHash);

            hashTable.AddElementToHashTable("abc");
            myHash = new SecondHash();
            hashTable.AddElementToHashTable("cat");
            myHash = new FirstHash();
            hashTable.AddElementToHashTable("dog");

            Assert.IsTrue(hashTable.IsContainInHashTable("abc"));
            Assert.IsTrue(hashTable.IsContainInHashTable("cat"));
            Assert.IsTrue(hashTable.IsContainInHashTable("dog"));
        }

        [Test]
        public void AddElementToHashTableAndDeleteElementOfHashTableShouldWork()
        {
            IMyHash myHash = new FirstHash();
            HashTable hashTable = new HashTable(myHash);

            hashTable.AddElementToHashTable("abc");
            hashTable.AddElementToHashTable("ver");
            myHash = new SecondHash();
            hashTable.DeleteElementOfHashTable("abc");
            myHash = new ThirdHash();
            hashTable.AddElementToHashTable("abc");
            myHash = new FirstHash();
            myHash = new SecondHash();
            hashTable.DeleteElementOfHashTable("ver");

            Assert.IsTrue(hashTable.IsContainInHashTable("abc"));
            Assert.IsFalse(hashTable.IsContainInHashTable("ver"));
        }

        [Test]
        public void ChangeHashShouldWork()
        {
            IMyHash myHash = new FirstHash();
            HashTable hashTable = new HashTable(myHash);


            hashTable.AddElementToHashTable("abc");
            hashTable.AddElementToHashTable("ver");
            myHash = new FirstHash();
            hashTable.ChangeHash(myHash);

            myHash = new SecondHash();
            hashTable.DeleteElementOfHashTable("abc");
            myHash = new ThirdHash();
            hashTable.AddElementToHashTable("abc");
            myHash = new FirstHash();
            myHash = new SecondHash();
            hashTable.DeleteElementOfHashTable("ver");

            Assert.IsTrue(hashTable.IsContainInHashTable("abc"));
            Assert.IsFalse(hashTable.IsContainInHashTable("ver"));
        }
    }
}
