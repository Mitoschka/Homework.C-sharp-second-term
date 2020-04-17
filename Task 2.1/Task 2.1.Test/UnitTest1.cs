using NUnit.Framework;

namespace Task_2._1.Test
{
    public class Tests
    {
        private MyList.MyList myList;

        [SetUp]
        public void Setup()
        {
            myList = new MyList.MyList();
        }


        [Test]
        public void AddElementAndDeleteElementTogetherWithGetItemValueShallWork1()
        {
            myList.AddElement(1, 0);
            myList.AddElement(2, 1);
            myList.AddElement(3, 2);
            myList.DeleteElement(0);

            Assert.AreEqual(2, myList.GetItemValue(0));
        }

        [Test]
        public void SizeOfListShallWork()
        {
            Assert.AreEqual(0, myList.SizeOfList());
        }

        [Test]
        public void AddElementAndDeleteElementTogetherWithGetItemValueShallWork2()
        {
            myList.AddElement(765, 0);
            myList.AddElement(-3, 1);
            myList.AddElement(45, 2);
            myList.AddElement(64, 3);
            myList.DeleteElement(0);
            myList.DeleteElement(1);

            Assert.AreEqual(-3, myList.GetItemValue(0));
        }

        [Test]
        public void AddElementAndDeleteElementTogetherWithSizeOfListShallWork()
        {
            myList.AddElement(28, 0);
            myList.AddElement(-54, 1);

            Assert.Throws<MyList.MyException>(() => myList.DeleteElement(2));
            Assert.AreEqual(2, myList.SizeOfList());
        }

        [Test]
        public void AddElementTogetherWithSizeOfListShallWork()
        {
            myList.AddElement(28, 0);
            myList.AddElement(72, 1);
            myList.AddElement(-94, 2);

            Assert.Throws<MyList.MyException>(() => myList.AddElement(1, 5));
            Assert.AreEqual(3, myList.SizeOfList());
        }

        [Test]
        public void AddElementTogetherWithGetItemValueShallWork1()
        {
            myList.AddElement(22, 0);
            myList.AddElement(0, 1);
            myList.AddElement(-4, 2);

            Assert.AreEqual(22, myList.GetItemValue(0));
        }

        [Test]
        public void AddElementTogetherWithGetItemValueShallWork2()
        {
            myList.AddElement(84, 0);
            myList.AddElement(-2, 1);
            myList.AddElement(5, 2);

            Assert.AreEqual(-2, myList.GetItemValue(1));
        }

        [Test]
        public void AddElementTogetherWithSizeOfListShallWork2()
        {
            Assert.Throws<MyList.MyException>(() => myList.AddElement(84, 1));
        }

        [Test]
        public void AddElementAndSetItemValueTogetherWithGetItemValueShallWork1()
        {
            myList.AddElement(5, 0);
            myList.AddElement(84, 1);
            myList.SetItemValue(0, 34);

            Assert.AreEqual(34, myList.GetItemValue(0));
        }

        [Test]
        public void AddElementAndSetItemValueTogetherWithGetItemValueShallWork2()
        {
            myList.AddElement(953, 0);
            myList.AddElement(-5, 1);
            myList.SetItemValue(1, 3);

            Assert.AreEqual(3, myList.GetItemValue(1));
        }

        [Test]
        public void Work2()
        {
            myList.AddElement(953, 0);
            myList.AddElement(-5, 1);
            myList.SetItemValue(1, 3);

            Assert.Throws<MyList.MyException>(() => myList.GetItemValue(21));
        }
    }
}