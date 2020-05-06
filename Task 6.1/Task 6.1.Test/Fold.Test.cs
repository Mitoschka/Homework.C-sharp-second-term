using NUnit.Framework;
using System.Collections.Generic;

namespace Task_6._1.Test
{
    public class FoldTest
    {
        [Test]
        public void FoldTestShoulWork()
        {
            var listOfFold = new List<int>() { 1, 2, 3, 4 };
            int result = 0;

            result = FoldFunction.Fold(listOfFold, 1, (x, y) => x * y);

            Assert.IsTrue(listOfFold.Contains(3));
            Assert.IsFalse(listOfFold.Contains(8));
            Assert.AreEqual(24, result);
        }

        [Test]
        public void FoldTestShoulWorkWithAddZeroValue()
        {
            var listOfFold = new List<int>() { 8, 6, 3, 0 };
            int result = 0;

            result = FoldFunction.Fold(listOfFold, 1, (x, y) => x * y);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void FoldTestShoulWorkWhenWeDoNotAddValues()
        {
            var listOfFold = new List<int>() {};
            int result = 0;

            result = FoldFunction.Fold(listOfFold, 1, (x, y) => x * y);

            Assert.AreEqual(1, result);
        }
    }
}