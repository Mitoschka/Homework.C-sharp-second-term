using NUnit.Framework;

namespace Task_2._3.Test
{
    public class TestsOfCalculator
    {
        private IStack stack;
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            stack = new StackOnList();
            calculator = new Calculator(stack);
        }

        [Test]
        public void ResultOfOperationsInArrayAndListShouldReturnTheCorrectResultOfTheOperation()
        {
            Assert.AreEqual(15, calculator.ResultOfOperations("1 4 - 2 3 + *"));
        }
    }
}
