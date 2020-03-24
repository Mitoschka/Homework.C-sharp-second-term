using NUnit.Framework;
using System.Collections.Generic;

namespace Task_6._1.Test
{
    public class FilterTest
    {
        FilterFunction FilterFunction;

        [SetUp]
        public void Setup()
        {
            FilterFunction = new FilterFunction();
        }

        [Test]
        public void FiterTestShoulWork()
        {
            List<int> listOfFilter = new List<int>();
            listOfFilter.Add(0);
            listOfFilter.Add(1);
            listOfFilter.Add(2);
            listOfFilter.Add(-1);
            listOfFilter.Add(3);
            listOfFilter.Add(4);
            listOfFilter.Add(-4);

            listOfFilter = FilterFunction.Filter(listOfFilter, x => x > 0);
            Assert.IsTrue(listOfFilter.Contains(2));
            Assert.IsFalse(listOfFilter.Contains(-1));
        }
    }
}