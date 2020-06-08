using NUnit.Framework;
using System.Collections.Generic;

namespace Task_6._1.Test
{
    public class MapTest
    {
        [Test]
        public void MapTestShoulWork()
        {
            var list = new List<int>() {0, 1, 2, 3, 4};

            list = MapFunction.Map(list, x => x * 2);

            Assert.IsTrue(list.Contains(8));
            Assert.IsFalse(list.Contains(10));
        }

        [Test]
        public void MapTestShoulWorkWhenWeDoNotAddValues()
        {
            var list = new List<int>() {};

            list = MapFunction.Map(list, x => x * 2);

            for (int i = 0; i <= 10; i++)
            {
                Assert.IsFalse(list.Contains(i));
            }
        }

        [Test]
        public void MapTestShoulWorkWithAddZeroValue()
        {
            var list = new List<int>() { 0, 0, 0, 0 };

            list = MapFunction.Map(list, x => x * 2);

            Assert.IsTrue(list.Contains(0));
            Assert.IsFalse(list.Contains(1));
        }
    }
}