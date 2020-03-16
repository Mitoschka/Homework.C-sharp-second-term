﻿using NUnit.Framework;

namespace Task_3._2.Test
{
    class FirstHashTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddElementToHashTableAndIsContainInHashTableShouldWork()
        {
            IMyHash myHash = new FirstHash();
            HashTable hashTable = new HashTable(myHash);

            hashTable.AddElementToHashTable("abc");

            Assert.IsTrue(hashTable.IsContainInHashTable("abc"));
        }

        [Test]
        public void AddElementToHashTableAndDeleteElementOfHashTableShouldWork()
        {
            IMyHash myHash = new FirstHash();
            HashTable hashTable = new HashTable(myHash);

            hashTable.AddElementToHashTable("abc");
            hashTable.AddElementToHashTable("ver");
            hashTable.DeleteElementOfHashTable("abc");

            Assert.IsFalse(hashTable.IsContainInHashTable("abc"));
        }
    }
}
