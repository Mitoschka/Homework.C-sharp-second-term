using System;

namespace Task_2._3
{
    /// <summary>
    /// Arithmetic operations
    /// </summary>
    public class Calculator
    {
        public Calculator(IStack stack1)
        {
            stack = stack1;
        }

        private IStack stack;

        /// <summary>
        /// Result of operations
        /// </summary>
        /// <param name="expression">The string that the user enters</param>
        /// <returns>Result of operations</returns>
        public int CalculateTheResultOfOperations(string expression)
        {
            string tmp = "";
            for (int i = 0; i != expression.Length; ++i)
            {
                if (expression[i] >= '0' && expression[i] <= '9')
                {
                    tmp += expression[i];
                }
                else
                {
                    if (tmp != "")
                    {
                        stack.Push(tmp);
                        tmp = "";
                    }
                    switch (expression[i])
                    {
                        case '/':
                            {
                                string divisor = stack.Pop();
                                int convertDivisor = Convert.ToInt32(divisor);
                                string dividend = stack.Pop();
                                int convertDividend = Convert.ToInt32(dividend);

                                int result = convertDividend / convertDivisor;

                                string quotient = Convert.ToString(result);
                                stack.Push(quotient);
                                break;
                            }
                        case '*':
                            {
                                string firstFactor = stack.Pop();
                                int convertFirstFactor = Convert.ToInt32(firstFactor);
                                string secondFactor = stack.Pop();
                                int convertSecondFactor = Convert.ToInt32(secondFactor);

                                int result = convertFirstFactor * convertSecondFactor;

                                string composition = Convert.ToString(result);
                                stack.Push(composition);
                                break;
                            }
                        case '+':
                            {
                                string firstMultiplier = stack.Pop();
                                int convertFirstMultiplier = Convert.ToInt32(firstMultiplier);
                                string secondMultiplier = stack.Pop();
                                int convertSecondMultiplier = Convert.ToInt32(secondMultiplier);

                                int result = convertFirstMultiplier + convertSecondMultiplier;

                                string sum = Convert.ToString(result);
                                stack.Push(sum);
                                break;
                            }
                        case '-':
                            {
                                string minuend = stack.Pop();
                                int convertMinuend = Convert.ToInt32(minuend);
                                string subtrahend = stack.Pop();
                                int convertSubtrahend = Convert.ToInt32(subtrahend);

                                int result = convertMinuend - convertSubtrahend;

                                string difference = Convert.ToString(result);
                                stack.Push(difference);
                                break;
                            }
                        case ' ':
                            {
                                break;
                            }
                        default:
                            {
                                throw new InvalidOperationException("Я не знаю такого символа");
                            }
                    }
                }
            }
            string peek = stack.Pop();
            int res = Convert.ToInt32(peek);
            return res;
        }
    }
}
