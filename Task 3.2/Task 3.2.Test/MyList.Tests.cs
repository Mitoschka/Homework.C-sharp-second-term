using NUnit.Framework;

namespace Task_3._2.Test
{
    public class TestsOfMyList
    {
        private MyList myList;

        [SetUp]
        public void Setup()
        {
            myList = new MyList();
        }

        [Test]
        public void SizeOfListMustBeEqualToTheNumberOfItemsAdded()
        {
            myList.AddElement("5");
            myList.AddElement("78");

            Assert.AreEqual(2, myList.SizeOfList());
        }

        [Test]
        public void SizeOfListShouldBeEqualToTheNumberOfRemainingItems()
        {
            myList.AddElement("5");
            myList.AddElement("78");
            myList.DeleteElement("5");

            Assert.AreEqual(1, myList.SizeOfList());
        }

        [Test]
        public void MyListShouldWorkWhenWeAddedHundredElements()
        {
            for (int i = 0; i < 100; i++)
            {
                myList.AddElement("5");
            }
            Assert.AreEqual(100, myList.SizeOfList());
        }

        [Test]
        public void CheckForEmptyList()
        {
            Assert.Throws<System.IndexOutOfRangeException>(() => myList.DeleteElement(" "));
        }
    }
}