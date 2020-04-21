using NUnit.Framework;

namespace Task_2._3.Test
{
    public class TestsOfMyStack
    {
        private static IStack stack;

        [TestCaseSource("DivideCases")]
        public void CountShouldCountTheNumberOfAddedItems(IStack stack)
        {
            stack.Push("34");
            stack.Push("8");
            stack.Pop();

            Assert.AreEqual(1, stack.Count());
        }

        [TestCaseSource("DivideCases")]
        public void PeekShouldPullOutTheLastItemAdded(IStack stack)
        {
            stack.Push("9");
            stack.Push("8");

            Assert.AreEqual("8", stack.Pop());
        }

        [TestCaseSource("DivideCases")]
        public void MyExeptionShouldWork(IStack stack)
        {
            Assert.Throws<MyException>(() => stack.Pop());
        }

        static object[] DivideCases =
        {
            stack = new StackOnList(),
              stack = new StackOnArray()
        };
    }
}
