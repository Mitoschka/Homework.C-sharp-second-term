using NUnit.Framework;

namespace Task_2._3.Test
{
    public class TestsOfMyList
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SizeOfListMustBeEqualToTheNumberOfItemsAdded()
        {
            MyList myList = new MyList();

            myList.AddElement("5");
            myList.AddElement("78");

            Assert.AreEqual(2, myList.SizeOfList());
        }

        [Test]
        public void SizeOfListShouldBeEqualToTheNumberOfRemainingItems()
        {
            MyList myList = new MyList();

            myList.AddElement("5");
            myList.AddElement("78");
            myList.RemoveElement();

            Assert.AreEqual(1, myList.SizeOfList());
        }
    }
}