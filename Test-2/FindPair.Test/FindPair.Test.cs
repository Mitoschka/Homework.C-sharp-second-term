using NUnit.Framework;

namespace FindPair.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PairTest()
        {
            GameForm testForm = new GameForm(6);
            int[] testArray = new int[17];
            foreach (int number in testForm.Numbers)
            {
                ++testArray[number];
            }
            for (int i = 0; i != 17; ++i)
            {
                Assert.AreEqual(2, testArray[i]);
            }
        }
    }
}