using NUnit.Framework;

namespace Task_7._1.Test
{
    public class CalculatorLogicTests
    {
        private CalculatorLogic calculatorLogic;

        [SetUp]
        public void Setup()
        {
            calculatorLogic = new CalculatorLogic();
        }

        [Test]
        public void TestOfCorrectWorkOfPlus()
        {
            calculatorLogic.Symbol = '+';
            calculatorLogic.FirstNum = 5;
            calculatorLogic.SecondNum = 6;

            calculatorLogic.Operation();

            Assert.AreEqual(11, calculatorLogic.FirstNum);
        }

        [Test]
        public void TestOfCorrectWorkOfMinus()
        {
            calculatorLogic.Symbol = '-';
            calculatorLogic.FirstNum = -30;
            calculatorLogic.SecondNum = -4;

            calculatorLogic.Operation();

            Assert.AreEqual(-26, calculatorLogic.FirstNum);
        }

        [Test]
        public void TestOfCorrectWorkOfDivised()
        {
            calculatorLogic.Symbol = '/';
            calculatorLogic.FirstNum = 15;
            calculatorLogic.SecondNum = 3;

            calculatorLogic.Operation();

            Assert.AreEqual(5, calculatorLogic.FirstNum);
        }

        [Test]
        public void TestOfCorrectWorkOfMultiply()
        {
            calculatorLogic.Symbol = '*';
            calculatorLogic.FirstNum = 5;
            calculatorLogic.SecondNum = -3;

            calculatorLogic.Operation();

            Assert.AreEqual(-15, calculatorLogic.FirstNum);
        }

        [Test]
        public void TestOfCorrectWorkOfSqrt()
        {
            double resultOfSqrt = 0;
            calculatorLogic.FirstNum = 25;

            calculatorLogic.SqrtMath(resultOfSqrt);

            Assert.AreEqual(5, calculatorLogic.FirstNum);
        }

        [Test]
        public void TestOfCorrectWorkOfDivisedOnOne()
        {
            double resultOfDivised = 0;
            calculatorLogic.FirstNum = 5;

            calculatorLogic.DivisedOnOne(resultOfDivised);

            Assert.AreEqual(0.20, calculatorLogic.FirstNum);
        }

        [Test]
        public void TestOfCorrectWorkOfPercent()
        {
            calculatorLogic.Symbol = '%';
            calculatorLogic.FirstNum = 10;
            calculatorLogic.SecondNum = 100;

            calculatorLogic.Operation();

            Assert.AreEqual(10, calculatorLogic.FirstNum);
        }

        [Test]
        public void TestOfCorrectWorkOfRemove()
        {
            calculatorLogic.FirstNum = 5;
            calculatorLogic.SecondNum = 6;

            calculatorLogic.Remove();

            Assert.AreEqual(0, calculatorLogic.FirstNum);
            Assert.AreEqual(0, calculatorLogic.SecondNum);
        }
    }
}