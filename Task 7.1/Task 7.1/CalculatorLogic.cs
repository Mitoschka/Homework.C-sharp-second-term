using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._1
{
    public class CalculatorLogic
    {
        private double result = 0;
        internal bool IsOperationPressedEarly { get; set; }
        internal bool IsContainDot { get; set; }
        internal bool IsEqualPressed { get; set; }
        public double SecondNum { get; set; } = 0;
        public double FirstNum { get; set; } = 0;
        public char Symbol { get; set; } = ' ';
        internal bool IsDelete { get; set; }

        internal void EqualButtonPressed()
        {
            Operation();
            IsOperationPressedEarly = false;
            IsEqualPressed = true;
        }

        public void Operation()
        {
            switch (Symbol)
            {
                case '+':
                    {
                        result = FirstNum + SecondNum;
                        break;
                    }
                case '-':
                    {
                        result = FirstNum - SecondNum;
                        break;
                    }
                case '*':
                    {
                        result = FirstNum * SecondNum;
                        break;
                    }
                case '/':
                    {
                        result = FirstNum / SecondNum;
                        break;
                    }
                case '%':
                    {
                        result = FirstNum * SecondNum / 100;
                        break;
                    }
            }
            FirstNum = result;
        }

        public void Remove()
        {
            FirstNum = 0;
            SecondNum = 0;
        }

        public void SqrtMath(double resultOfSqrt)
        {
            resultOfSqrt = Math.Sqrt(FirstNum);
            FirstNum = resultOfSqrt;
        }

        public void DivisedOnOne(double resultDivisedOnOne)
        {
            resultDivisedOnOne = 1 / FirstNum;
            FirstNum = resultDivisedOnOne;
        }
    }
}