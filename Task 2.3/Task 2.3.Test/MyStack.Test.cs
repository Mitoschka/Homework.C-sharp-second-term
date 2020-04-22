using System.Collections;
using NUnit.Framework;

namespace Task_2._3.Test
{
    public class TestsOfMyStack
    {
        [TestCaseSource(typeof(DivideCases))]
        public void CountShouldCountTheNumberOfAddedItems(IStack stack)
        {
            stack.Push(34);
            stack.Push(8);
            stack.Pop();

            Assert.AreEqual(1, stack.Count());
        }

        [TestCaseSource(typeof(DivideCases))]
        public void PushShouldWorkWhenWeAddedHundredElements(IStack stack)
        {
            for (int i = 0; i < 100; i++)
            {
                stack.Push(1);
            }
            Assert.AreEqual(100, stack.Count());
        }

        [TestCaseSource(typeof(DivideCases))]
        public void PushShouldWorkWhenWeAddedHundredAndOneElements(IStack stack)
        {
            for (int i = 0; i <= 100; i++)
            {
                stack.Push(1);
            }
            Assert.AreEqual(101, stack.Count());
        }

        [TestCaseSource(typeof(DivideCases))]
        public void PushAndPopShouldWorkCorrect(IStack stack)
        {
            stack.Push(9);
            stack.Push(8);
            stack.Pop();
            stack.Pop();

            Assert.Throws<MyException>(() => stack.Pop());
            Assert.AreEqual(0, stack.Count());
        }

        [TestCaseSource(typeof(DivideCases))]
        public void PushShouldWorkCorrect(IStack stack)
        {
            stack.Push(9);
            stack.Push(8);

            Assert.AreEqual(8, stack.Pop());
        }

        [TestCaseSource(typeof(DivideCases))]
        public void MyExeptionShouldWork(IStack stack)
        {
            Assert.Throws<MyException>(() => stack.Pop());
        }

        class DivideCases : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
               yield return new StackOnList();
               yield return new StackOnArray();
            }
        }
    }
}
