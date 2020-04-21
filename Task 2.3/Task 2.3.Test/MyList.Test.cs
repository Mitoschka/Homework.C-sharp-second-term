using NUnit.Framework;

namespace Task_2._3.Test
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
            myList.RemoveElement();

            Assert.AreEqual(1, myList.SizeOfList());
        }
    }
}