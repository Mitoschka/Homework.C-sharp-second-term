using NUnit.Framework;

namespace Task_2._3.Test
{
    public class TestsOfCalculator
    {
        [TestCaseSource("DivideCases")]
        public void DivideTest(Calculator calculator)
        {
            Assert.AreEqual(15, calculator.CalculateTheResultOfOperations("1 4 - 2 3 + *"));
        }

        static object[] DivideCases =
        {
            new Calculator(new StackOnList()),
               new Calculator(new StackOnArray())
        };
    }
}
