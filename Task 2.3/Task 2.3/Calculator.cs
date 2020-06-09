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
        public Calculator(IStack stack)
        {
            this.stack = stack;
        }

        private readonly IStack stack;

        /// <summary>
        /// Result of operations
        /// </summary>
        /// <param name="expression">The string that the user enters</param>
        /// <returns>Result of operations</returns>
        public int CalculateTheResultOfOperations(string expression)
        {
            if (!expression.Contains('-') && !expression.Contains('+') && !expression.Contains('*') && !expression.Contains('/'))
            {
                if (expression == "")
                {
                    throw new System.ArgumentException("Не верный ввод");
                }
                for (int i = 0; i != expression.Length; ++i)
                {
                    if (expression[i] <= '0' || expression[i] >= '9')
                    {
                        throw new System.ArgumentException("Не верный ввод");
                    }
                }
                return Convert.ToInt32(expression);
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
                    switch (expression[i])
                    {
                        case '/':
                            {
                                int firstNum = stack.Pop();
                                int secondNum = stack.Pop();
                                if (secondNum == 0)
                                {
                                    throw new System.InvalidOperationException("На ноль делить нельзя");
                                }
                                int result = firstNum / secondNum;
                                stack.Push(result);
                                break;
                            }
                        case '*':
                            {
                                int firstNum = stack.Pop();
                                int secondNum = stack.Pop();
                                int result = firstNum * secondNum;
                                stack.Push(result);
                                break;
                            }
                        case '+':
                            {
                                int firstNum = stack.Pop();
                                int secondNum = stack.Pop();
                                int result = firstNum + secondNum;
                                stack.Push(result);
                                break;
                            }
                        case '-':
                            {
                                int firstNum = stack.Pop();
                                int secondNum = stack.Pop();
                                int result = firstNum - secondNum;
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
