using System;

/// <summary>
/// Global namespace.
/// </summary>
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
            if (!expression.Contains('-') && !expression.Contains('+') && !expression.Contains('*') && !expression.Contains('/'))
            {
                throw new System.InvalidOperationException("Не верный ввод");
            }
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
                        int num = Convert.ToInt32(tmp);
                        stack.Push(num);
                        tmp = "";
                    }
                    int result = 0;
                    switch (expression[i])
                    {
                        case '/':
                            {
                                int firstNum = stack.Pop();
                                int secondNum = stack.Pop();
                                result = firstNum / secondNum;
                                stack.Push(result);
                                break;
                            }
                        case '*':
                            {
                                int firstNum = stack.Pop();
                                int secondNum = stack.Pop();
                                result = firstNum * secondNum;
                                stack.Push(result);
                                break;
                            }
                        case '+':
                            {
                                int firstNum = stack.Pop();
                                int secondNum = stack.Pop();
                                result = firstNum + secondNum;
                                stack.Push(result);
                                break;
                            }
                        case '-':
                            {
                                int firstNum = stack.Pop();
                                int secondNum = stack.Pop();
                                result = firstNum - secondNum;
                                stack.Push(result);
                                break;
                            }
                        case ' ':
                            {
                                break;
                            }
                        default:
                            {
                                throw new System.InvalidOperationException("Я не знаю такого символа");
                            }
                    }
                }
            }
            int res = stack.Pop();
            return res;
        }
    }
}
