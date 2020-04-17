using NUnit.Framework;

namespace Task_2._3.Test
{
    public class TestsOfStackOnArray
    {
        IStack stack;

        [SetUp]
        public void Setup()
        {
            stack = new StackOnArray();
        }

        [Test]
        public void PeekShouldPullOutTheLastItemAdded()
        {
            stack.Push("34");
            stack.Push("8");

            Assert.AreEqual("8", stack.Peek());
        }

        [Test]
        public void CountShouldCountTheNumberOfAddedItems()
        {
            stack.Push("34");
            stack.Push("8");
            stack.Peek();

            Assert.AreEqual(1, stack.Count());
        }
    }
}