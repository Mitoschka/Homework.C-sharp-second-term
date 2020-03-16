using NUnit.Framework;

namespace Task_2._2.Test
{
    public class Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddUniqueElementToListShouldWorkTrue()
        {
            MyList list = new MyList();

            list.AddUniqueElementToList("abc");

            Assert.IsTrue(list.IsContain("abc"));
        }

        [Test]
        public void AddUniqueElementToListShouldWorkFalse()
        {
            MyList list = new MyList();

            list.AddUniqueElementToList("abc");

            Assert.IsFalse(list.IsContain("ver"));
        }

        [Test]
        public void AddUniqueElementToListAndDeleteElementShouldWork()
        {
            MyList list = new MyList();

            list.AddUniqueElementToList("abc");
            list.AddUniqueElementToList("ver");
            list.DeleteElement("abc");

            Assert.IsFalse(list.IsContain("abc"));
            Assert.IsTrue(list.IsContain("ver"));
        }

        [Test]
        public void AddElementAndAddUniqueElementToListShouldWork()
        {
            MyList list = new MyList();

            list.AddElement("abc");
            list.AddUniqueElementToList("abc");
            list.AddElement("abc");

            Assert.AreEqual(2, list.SizeOfList());
        }

    }
}
