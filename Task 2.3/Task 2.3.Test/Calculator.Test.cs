using NUnit.Framework;

namespace Task_2._3.Test
{
    public class TestsOfCalculator
    {
        [TestCaseSource("stackImplementation")]
        public void CalculateTest(Calculator calculator)
        {
            Assert.AreEqual(15, calculator.CalculateTheResultOfOperations("1 4 - 2 3 + *"));
        }

        [TestCaseSource("stackImplementation")]
        public void CalculateTestIfWeDivideByZero(Calculator calculator)
        {
            Assert.Throws<System.InvalidOperationException>(() => calculator.CalculateTheResultOfOperations("0 3 /"));
        }

        [TestCaseSource("stackImplementation")]
        public void CalculateShouldWorkWhenWeNotAdd(Calculator calculator)
        {
            Assert.Throws<System.ArgumentException>(() => calculator.CalculateTheResultOfOperations(""));
        }

        [TestCaseSource("stackImplementation")]
        public void CalculateTestWhenWeAddOnlyOperator(Calculator calculator)
        {
            Assert.Throws<System.InvalidOperationException>(() => calculator.CalculateTheResultOfOperations("-"));
            Assert.Throws<System.InvalidOperationException>(() => calculator.CalculateTheResultOfOperations("+ - / *"));
        }

        [TestCaseSource("stackImplementation")]
        public void CalculateTestWhenWeAddOnlyOperand(Calculator calculator)
        {
            Assert.Throws<System.ArgumentException>(() => calculator.CalculateTheResultOfOperations("32 6 3"));
        }

        [TestCaseSource("stackImplementation")]
        public void CalculateOneNumberTest(Calculator calculator)
        {
            Assert.AreEqual(6, calculator.CalculateTheResultOfOperations("6"));
        }

        private static object[] stackImplementation =
        {
            new Calculator(new StackOnList()),
               new Calculator(new StackOnArray())
        };
    }
}
