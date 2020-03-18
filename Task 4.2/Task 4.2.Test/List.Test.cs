using MyList;
using NUnit.Framework;

namespace Task_4._2.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddUniqueElementToListShouldWorkTrue()
        {
            UniqueList list = new UniqueList();

            list.AddUniqueElementToList("abc");

            Assert.IsTrue(list.IsContain("abc"));
        }

        [Test]
        public void AddUniqueElementToListShouldWorkFalse()
        {
            UniqueList list = new UniqueList();

            list.AddUniqueElementToList("abc");

            Assert.IsFalse(list.IsContain("ver"));
        }
    }
}