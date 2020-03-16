using NUnit.Framework;

namespace Task_2._3.Test
{
    public class TestsOfCalculator
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ResultOfOperationsInArrayShouldReturnTheCorrectResultOfTheOperation()
        {
            IStack stack = new StackOnArray();
            Calculator calculator = new Calculator(stack);

            Assert.AreEqual(15, calculator.ResultOfOperations("1 4 - 2 3 + *"));
        }

        [Test]
        public void ResultOfOperationsInListShouldReturnTheCorrectResultOfTheOperation()
        {
            IStack stack = new StackOnList();
            Calculator calculator = new Calculator(stack);

            Assert.AreEqual(15, calculator.ResultOfOperations("1 4 - 2 3 + *"));
        }
    }
}
