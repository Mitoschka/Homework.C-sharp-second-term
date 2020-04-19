using NUnit.Framework;

namespace Task_2._3.Test
{
    public class TestsOfStackOnList
    {
        private IStack stack;

        [SetUp]
        public void Setup()
        {
            stack = new StackOnList();
        }

        [Test]
        public void CountShouldCountTheNumberOfAddedItems()
        {
            stack.Push("34");
            stack.Push("-4");
            stack.Pop();

            Assert.AreEqual(1, stack.Count());
        }

        [Test]
        public void PeekShouldPullOutTheLastItemAdded()
        { 
            stack.Push("34");
            stack.Push("8");

            Assert.AreEqual("8", stack.Pop());
        }

        [Test]
        public void PeekShouldWorkInEmptyStack()
        {
            Assert.Throws<MyException>(() => stack.Pop());
        }
    }
}