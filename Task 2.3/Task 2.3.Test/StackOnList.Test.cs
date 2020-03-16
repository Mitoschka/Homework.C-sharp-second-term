using NUnit.Framework;

namespace Task_2._3.Test
{
    public class TestsOfStackOnList
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CountShouldCountTheNumberOfAddedItems()
        {
            IStack stack = new StackOnList();

            stack.Push("34");
            stack.Push("-4");
            stack.Peek();

            Assert.AreEqual(1, stack.Count());
        }

        [Test]
        public void PeekShouldPullOutTheLastItemAdded()
        {
            IStack stack = new StackOnList();

            stack.Push("34");
            stack.Push("8");

            Assert.AreEqual("8", stack.Peek());
        }
    }
}