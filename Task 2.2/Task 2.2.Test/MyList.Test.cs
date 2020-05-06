using NUnit.Framework;

namespace Task_2._2.Test
{
    public class ListTests
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

            Assert.IsTrue(list.Contains("abc"));
        }

        [Test]
        public void AddUniqueElementToListShouldWorkFalse()
        {
            list.AddUniqueElementToList("abc");

            Assert.IsFalse(list.Contains("ver"));
        }

        [Test]
        public void AddUniqueElementToListAndDeleteElementShouldWork()
        {
            list.AddUniqueElementToList("abc");
            list.AddUniqueElementToList("ver");
            list.DeleteElement("abc");

            Assert.IsFalse(list.Contains("abc"));
            Assert.IsTrue(list.Contains("ver"));
        }

        [Test]
        public void AddElementAndAddUniqueElementToListShouldWork()
        {
            list.AddElement("1");
            list.AddUniqueElementToList("1");
            list.AddElement("2");
            list.AddElement("3");
            list.AddElement("4");
            list.AddElement("lce");
            list.AddElement("abc");

            Assert.AreEqual(2, list.SizeOfList());
        }

    }
}
