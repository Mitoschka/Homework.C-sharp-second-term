using NUnit.Framework;

namespace Task_3._2.Test
{
    class FirstHashTests
    {
        public class TestsOfHash
        {
            [TestCaseSource("DivideCases")]
            public void AddElementToHashTableAndIsContainInHashTableShouldWork(HashTable hashTable)
            {
                hashTable.AddElementToHashTable("abc");

                Assert.IsTrue(hashTable.IsContainInHashTable("abc"));
            }

            [TestCaseSource("DivideCases")]
            public void AddElementToHashTableAndDeleteElementOfHashTableShouldWork(HashTable hashTable)
            {
                hashTable.AddElementToHashTable("abc");
                hashTable.AddElementToHashTable("ver");
                hashTable.DeleteElementOfHashTable("abc");

                Assert.IsFalse(hashTable.IsContainInHashTable("abc"));
            }

            static object[] DivideCases =
            {
            new HashTable(new FirstHash()),
               new HashTable(new SecondHash()),
               new HashTable(new ThirdHash()),
        };
        }
    }
}
