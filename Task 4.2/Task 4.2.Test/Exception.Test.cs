using Task_4._2;
using NUnit.Framework;

namespace Task_4._2.Test
{
    class ExceptionTest
    {
        private UniqueList unique;

        [SetUp]
        public void Setup()
        {
            unique = new UniqueList();
        }

        [Test]
        public void AddUniqueElementToListTest()
        {
            unique.AddUniqueElementToList("dog", 0);
            Assert.Throws<AddException>(() => unique.AddUniqueElementToList("dog", 0));
        }

        [Test]
        public void DeleteElementFromEmptyListTest()
        {
            unique.AddUniqueElementToList("dog", 0);
            unique.DeleteElement(0);
            Assert.Throws<DeleteException>(() => unique.DeleteElement(0));
        }

        [Test]
        public void DeleteElementFromListTest()
        {
            unique.AddUniqueElementToList("dog", 0);
            Assert.Throws<System.ArgumentOutOfRangeException>(() => unique.DeleteElement(1));
        }
    }
}
