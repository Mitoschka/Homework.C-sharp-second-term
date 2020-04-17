using NUnit.Framework;

namespace Task_2._2.Test
{
    public class Test
    {
        private MyList list;

        [SetUp]
        public void Setup()
        {
            list = new MyList();
        }

        [Test]
        public void AddUniqueElementToListShouldWorkTrue()
        {
            list.AddUniqueElementToList("abc");

            Assert.IsTrue(list.IsContain("abc"));
        }

        [Test]
        public void AddUniqueElementToListShouldWorkFalse()
        {
            list.AddUniqueElementToList("abc");

            Assert.IsFalse(list.IsContain("ver"));
        }

        [Test]
        public void AddUniqueElementToListAndDeleteElementShouldWork()
        {
            list.AddUniqueElementToList("abc");
            list.AddUniqueElementToList("ver");
            list.DeleteElement("abc");

            Assert.IsFalse(list.IsContain("abc"));
            Assert.IsTrue(list.IsContain("ver"));
        }

        [Test]
        public void AddElementAndAddUniqueElementToListShouldWork()
        {
            list.AddElement("abc");
            list.AddUniqueElementToList("abc");
            list.AddElement("abc");

            Assert.AreEqual(2, list.SizeOfList());
        }

    }
}
