using NUnit.Framework;
using System.Collections.Generic;

namespace Task_6._1.Test
{
    public class MapTest
    {
        MapFunction mapFunction;

        [SetUp]
        public void Setup()
        {
            mapFunction = new MapFunction();
        }

        [Test]
        public void MapTestShoulWork()
        {
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            list = mapFunction.Map(list, x => x * 2);

            Assert.IsTrue(list.Contains(8));
            Assert.IsFalse(list.Contains(10));
        }
    }
}