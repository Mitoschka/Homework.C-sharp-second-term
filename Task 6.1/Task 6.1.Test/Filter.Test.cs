using NUnit.Framework;
using System.Collections.Generic;

namespace Task_6._1.Test
{
    public class FilterTest
    {
        [Test]
        public void FilterTestShoulWork()
        {
            var listOfFilter = new List<int>() {1, 2, 3, 4};

            listOfFilter = FilterFunction.Filter(listOfFilter, x => x > 0);

            Assert.IsTrue(listOfFilter.Contains(2));
            Assert.IsFalse(listOfFilter.Contains(-1));
        }

        [Test]
        public void FilterTestShoulWorkWithAddZeroValue()
        {
            var listOfFilter = new List<int>() {0, 0, 1, 0 };

            listOfFilter = FilterFunction.Filter(listOfFilter, x => x > 0);

            Assert.IsTrue(listOfFilter.Contains(1));
            Assert.IsFalse(listOfFilter.Contains(0));
        }

        [Test]
        public void FilterTestShoulWorkWhenWeDoNotAddValues()
        {
            var listOfFilter = new List<int>() {};

            listOfFilter = FilterFunction.Filter(listOfFilter, x => x > 0);

            for (int i = 0; i <= 10; i++)
            {
                Assert.IsFalse(listOfFilter.Contains(i));
            }
        }
    }
}
