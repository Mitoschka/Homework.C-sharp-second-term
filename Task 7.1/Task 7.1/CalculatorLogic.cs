using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._1
{
    public class CalculatorLogic
    {
        double firstNum = 0;
        double secondNum = 0;
        double result = 0;
        char sumbol = ' ';
        bool isOperationPressedEarly = false;
        bool isEqualPressed = false;
        bool isContainDot = false;

        public bool IsOperationPressedEarly { get => isOperationPressedEarly; set => isOperationPressedEarly = value; }
        public bool IsContainDot { get => isContainDot; set => isContainDot = value; }
        public bool IsEqualPressed { get => isEqualPressed; set => isEqualPressed = value; }
        public double SecondNum { get => secondNum; set => secondNum = value; }
        public double FirstNum { get => firstNum; set => firstNum = value; }
        public char Sumbol { get => sumbol; set => sumbol = value; }

        internal void EqualButtonPressed()
        {
            Operation();
            IsOperationPressedEarly = false;
            IsEqualPressed = true;
        }
        public void Operation()
        {
            switch (Sumbol)
            {
                case '+':
                    {

                        result = FirstNum + SecondNum;
                        FirstNum = result;
                        break;
                    }
                case '-':
                    {
                        result = FirstNum - SecondNum;
                        FirstNum = result;
                        break;
                    }
                case '*':
                    {
                        result = FirstNum * SecondNum;
                        FirstNum = result;
                        break;
                    }
                case '/':
                    {
                        result = FirstNum / SecondNum;
                        FirstNum = result;
                        break;
                    }
                case '%':
                    {
                        result = FirstNum * SecondNum / 100;
                        FirstNum = result;
                        break;
                    }
            }
        }
        public void Remove()
        {
            FirstNum = 0;
            SecondNum = 0;
        }
        public void SqrtMath(double resultOfSqrt)
        {
            resultOfSqrt = Math.Sqrt(firstNum);
            firstNum = resultOfSqrt;
        }
        public void DivisedOnOne(double resultDivisedOnOne)
        {
            resultDivisedOnOne = 1 / firstNum;
            firstNum = resultDivisedOnOne;
        }
    }
}
