using NUnit.Framework;

namespace Task_2._3.Test
{
    public class TestsOfCalculator
    {
        [TestCaseSource("StackImplementation")]
        public void CalculateTest(Calculator calculator)
        {
            Assert.AreEqual(15, calculator.CalculateTheResultOfOperations("1 4 - 2 3 + *"));
        }

        [TestCaseSource("StackImplementation")]
        public void CalculateShouldWorkWhenWeNotAdd(Calculator calculator)
        {
            Assert.Throws<System.InvalidOperationException>(() => calculator.CalculateTheResultOfOperations(""));
        }

        [TestCaseSource("StackImplementation")]
        public void CalculateTestWhenWeAddOnlyOperator(Calculator calculator)
        {
            Assert.Throws<System.InvalidOperationException>(() => calculator.CalculateTheResultOfOperations("-"));
            Assert.Throws<System.InvalidOperationException>(() => calculator.CalculateTheResultOfOperations("+ - / *"));
        }

        [TestCaseSource("StackImplementation")]
        public void CalculateTestWhenWeAddOnlyOperand(Calculator calculator)
        {
            Assert.Throws<System.InvalidOperationException>(() => calculator.CalculateTheResultOfOperations("32 6 3"));
        }

        static object[] StackImplementation =
        {
            new Calculator(new StackOnList()),
               new Calculator(new StackOnArray())
        };
    }
}
