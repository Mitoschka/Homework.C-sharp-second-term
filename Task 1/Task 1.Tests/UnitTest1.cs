using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testQueue
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(EmptyQueueException))]
        public void TestMethod1()
        {
            //проверяем что работает исключение когда достаем из пустой очереди
            Queue<string> queue = new Queue<string>();
            string test = queue.Dequeue();
        }

        [TestMethod]
        public void TestMethod2()
        {
            Queue<char> queue = new Queue<char>();
            queue.Enqueue('a', 2);
            queue.Enqueue('b', 1);
            queue.Enqueue('c', 4);
            Assert.AreEqual('c', queue.Dequeue());
            Assert.AreEqual('a', queue.Dequeue());
            Assert.AreEqual('b', queue.Dequeue());
        }

        [TestMethod]
        public void TestMethod3()
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
