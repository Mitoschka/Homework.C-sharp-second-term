using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._1
{
    public class CalculatorLogic
    {
        private double firstNum = 0;
        private double secondNum = 0;
        private double result = 0;
        private char symbol = ' ';
        private bool isOperationPressedEarly = false;
        private bool isEqualPressed = false;
        private bool isContainDot = false;
        private bool isDelete = false;

        internal bool IsOperationPressedEarly
        {
            get => isOperationPressedEarly;
            set => isOperationPressedEarly = value;
        }
        internal bool IsContainDot
        {
            get => isContainDot;
            set => isContainDot = value;
        }
        internal bool IsEqualPressed
        {
            get => isEqualPressed;
            set => isEqualPressed = value;
        }
        public double SecondNum
        {
            get => secondNum;
            set => secondNum = value;
        }
        public double FirstNum
        {
            get => firstNum;
            set => firstNum = value;
        }
        public char Symbol
        {
            get => symbol;
            set => symbol = value;
        }
        internal bool IsDelete
        {
            get => isDelete;
            set => isDelete = value;
        }

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