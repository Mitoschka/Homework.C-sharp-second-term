using NUnit.Framework;

namespace Task_2._3.Test
{
    public class TestsOfStackOnArray
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PeekShouldPullOutTheLastItemAdded()
        {
            IStack stack = new StackOnArray();

            stack.Push("34");
            stack.Push("8");

            Assert.AreEqual("8", stack.Peek());
        }

        [Test]
        public void CountShouldCountTheNumberOfAddedItems()
        {
            IStack stack = new StackOnArray();

            stack.Push("34");
            stack.Push("8");
            stack.Peek();

            Assert.AreEqual(1, stack.Count());
        }
    }
}