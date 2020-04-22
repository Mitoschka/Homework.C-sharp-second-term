using NUnit.Framework;

namespace Task_2._3.Test
{
    public class TestsOfCalculator
    {
        [TestCaseSource("DivideCases")]
        public void CalculateTest(Calculator calculator)
        {
            Assert.AreEqual(15, calculator.CalculateTheResultOfOperations("1 4 - 2 3 + *"));
        }

        [TestCaseSource("DivideCases")]
        public void CalculateShoulWorkWhenWeNotAdd(Calculator calculator)
        {
            Assert.Throws<System.InvalidOperationException>(() => calculator.CalculateTheResultOfOperations(""));
        }

        [TestCaseSource("DivideCases")]
        public void CalculateTestWhenWeAddOnlyOperator(Calculator calculator)
        {
            Assert.Throws<MyException>(() => calculator.CalculateTheResultOfOperations("-"));
            Assert.Throws<MyException>(() => calculator.CalculateTheResultOfOperations("+ - / *"));
        }

        [TestCaseSource("DivideCases")]
        public void CalculateTestWhenWeAddOnlyOperand(Calculator calculator)
        {
            Assert.Throws<MyException>(() => calculator.CalculateTheResultOfOperations("-5"));
            Assert.Throws<System.InvalidOperationException>(() => calculator.CalculateTheResultOfOperations("32 6 3"));
        }

        static object[] DivideCases =
        {
            new Calculator(new StackOnList()),
               new Calculator(new StackOnArray())
        };
    }
}
