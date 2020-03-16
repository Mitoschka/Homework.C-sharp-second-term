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

        IStack stack;

        /// <summary>
        /// Result of operations
        /// </summary>
        /// <param name="expression">The string that the user enters</param>
        /// <returns>Result of operations</returns>
        public int ResultOfOperations(string expression)
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
                                string divisor = stack.Peek();
                                int convertDivisor = Convert.ToInt32(divisor);
                                string dividend = stack.Peek();
                                int convertDividend = Convert.ToInt32(dividend);

                                int result = convertDividend / convertDivisor;

                                string quotient = Convert.ToString(result);
                                stack.Push(quotient);
                                break;
                            }
                        case '*':
                            {
                                string firstFactor = stack.Peek();
                                int convertFirstFactor = Convert.ToInt32(firstFactor);
                                string secondFactor = stack.Peek();
                                int convertSecondFactor = Convert.ToInt32(secondFactor);

                                int result = convertFirstFactor * convertSecondFactor;

                                string produs = Convert.ToString(result);
                                stack.Push(produs);
                                break;
                            }
                        case '+':
                            {
                                string firstMultiplier = stack.Peek();
                                int convertFirstMultiplier = Convert.ToInt32(firstMultiplier);
                                string secondMultiplier = stack.Peek();
                                int convertSecondMultiplier = Convert.ToInt32(secondMultiplier);

                                int result = convertFirstMultiplier + convertSecondMultiplier;

                                string sum = Convert.ToString(result);
                                stack.Push(sum);
                                break;
                            }
                        case '-':
                            {
                                string minuend = stack.Peek();
                                int convertMinuend = Convert.ToInt32(minuend);
                                string subtrahend = stack.Peek();
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
            string peek = stack.Peek();
            int res = Convert.ToInt32(peek);
            return res;
        }
    }
}
