using NUnit.Framework;

namespace Task_1.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void AnExceptionShouldWorksWhenGetItFromAnEmptyQueue()
        {
            Queue<string> queue = new Queue<string>();
            Assert.Throws<EmptyQueueException>(() => queue.Dequeue());
        }

        [Test]
        public void QueueWithCharShoulWork()
        {
            Queue<char> queue = new Queue<char>();
            queue.Enqueue('a', 2);
            queue.Enqueue('b', 1);
            queue.Enqueue('c', 4);
            Assert.AreEqual('c', queue.Dequeue());
            Assert.AreEqual('a', queue.Dequeue());
            Assert.AreEqual('b', queue.Dequeue());
        }

        [Test]
        public void QueueWithIntegerShoulWork()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10, 1);
            queue.Enqueue(12, 5);
            queue.Enqueue(2, 3);
            Assert.AreEqual(12, queue.Dequeue());
            Assert.AreEqual(2, queue.Dequeue());
            queue.Enqueue(-2, 7);
            queue.Enqueue(0, 0);
            Assert.AreEqual(-2, queue.Dequeue());
            Assert.AreEqual(10, queue.Dequeue());
            Assert.AreEqual(0, queue.Dequeue());
        }
    }
}