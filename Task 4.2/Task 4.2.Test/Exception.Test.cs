using MyList;
using NUnit.Framework;

namespace Task_4._2.Test
{
    class ExceptionTest
    {
        UniqueList unique;

        [SetUp]
        public void Setup()
        {
            unique = new UniqueList();
        }

        [Test]
        public void AddUniqueElementToListTest()
        {
            unique.AddUniqueElementToList("dog");
            Assert.Throws<AddException>(() => unique.AddUniqueElementToList("dog"));
        }

        [Test]
        public void DeleteElementFromEmptyListTest()
        {
            unique.AddUniqueElementToList("dog");
            unique.DeleteElement("dog");
            Assert.Throws<DeleteException>(() => unique.DeleteElement("dog"));
        }
    }
}
