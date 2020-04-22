using Task_4._2;
using NUnit.Framework;

namespace Task_4._2.Test
{
    public class UniqueListTests
    {
        private UniqueList list;

        [SetUp]
        public void Setup()
        {
            list = new UniqueList();
        }

        [Test]
        public void AddUniqueElementToListShouldWork()
        {
            list.AddUniqueElementToList("abc", 0);

            Assert.AreEqual("abc", list.GetItemValue(0));
            Assert.AreEqual(1, list.SizeOfList());
        }

        [Test]
        public void SetElementAndAddUniqueElementToListShouldWork()
        {
            list.AddUniqueElementToList("dog", 0);
            list.SetItemValue(0, "cat");

            Assert.AreEqual("cat", list.GetItemValue(0));
            Assert.AreEqual(1, list.SizeOfList());
        }

        [Test]
        public void ShouldThrowAddException()
        {
            list.AddUniqueElementToList("abc", 0);

            Assert.Throws<AddException>(() => list.AddUniqueElementToList("abc", 1));
            Assert.Throws<AddException>(() => list.AddUniqueElementToList("abc", 0));
        }
    }
}