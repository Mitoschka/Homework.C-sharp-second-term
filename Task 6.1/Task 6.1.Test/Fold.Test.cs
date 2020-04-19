using NUnit.Framework;
using System.Collections.Generic;

namespace Task_6._1.Test
{
    public class FoldTest
    {
        private FoldFunction FoldFunction;

        [SetUp]
        public void Setup()
        {
            FoldFunction = new FoldFunction();
        }

        [Test]
        public void FoldTestShoulWork()
        {
            var listOfFold = new List<int>();
            int result = 0;

            listOfFold.Add(1);
            listOfFold.Add(2);
            listOfFold.Add(3);
            listOfFold.Add(4);

            result = FoldFunction.Fold(listOfFold, 1, (x, y) => x * y);

            Assert.IsTrue(listOfFold.Contains(3));
            Assert.IsFalse(listOfFold.Contains(8));
            Assert.AreEqual(24, result);
        }
    }
}