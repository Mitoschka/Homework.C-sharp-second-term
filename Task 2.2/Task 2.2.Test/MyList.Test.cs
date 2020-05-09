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
            list.AddUniqueElementToList("ver");
            list.AddUniqueElementToList("car");
            list.AddUniqueElementToList("abc");

            Assert.IsTrue(list.Contains("car"));
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
            list.AddElement("abc");
            list.AddUniqueElementToList("abc");
            list.AddElement("abc");

            Assert.AreEqual(2, list.SizeOfList());
        }

        [Test]
        public void ShouldThrowExceptionWhenWeDeleteEmpty()
        {
            Assert.Throws <System.NullReferenceException>(() => list.DeleteElement("abc"));
        }
    }
}
