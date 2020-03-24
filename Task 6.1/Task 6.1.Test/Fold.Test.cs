using NUnit.Framework;
using System.Collections.Generic;

namespace Task_6._1.Test
{
    public class FoldTest
    {
        FoldFunction FoldFunction;

        [SetUp]
        public void Setup()
        {
            FoldFunction = new FoldFunction();
        }

        [Test]
        public void FoldTestShoulWork()
        {
            List<int> listOfFold = new List<int>();
            listOfFold.Add(1);
            listOfFold.Add(2);
            listOfFold.Add(3);
            listOfFold.Add(4);

            listOfFold = FoldFunction.Fold(listOfFold, 1, (x, y) => x * y);
            Assert.IsTrue(listOfFold.Contains(6));
            Assert.IsFalse(listOfFold.Contains(8));
        }
    }
}