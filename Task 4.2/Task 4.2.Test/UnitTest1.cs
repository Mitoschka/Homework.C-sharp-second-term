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

        [Test]
        public void AddUniqueElementToListAndDeleteElementShouldWork()
        {
            UniqueList list = new UniqueList();

            list.AddUniqueElementToList("abc");
            list.AddUniqueElementToList("ver");
            list.DeleteElement("abc");

            Assert.IsFalse(list.IsContain("abc"));
            Assert.IsTrue(list.IsContain("ver"));
        }

        [Test]
        public void AddElementAndAddUniqueElementToListShouldWork()
        {
            UniqueList list = new UniqueList();

            list.AddElement("abc");
            list.AddUniqueElementToList("abc");
            list.AddElement("abc");

            Assert.AreEqual(2, list.SizeOfList());
        }
    }
}