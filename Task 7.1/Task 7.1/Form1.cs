using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if (inputAndOutputLine.Text.Length == 0)
            {
                return;
            }
            switch (sumbol)
            {
                case '+':
                    {
                        secondNum = Convert.ToDouble(inputAndOutputLine.Text);
                        result = firstNum + secondNum;
                        firstNum = result;
                        inputAndOutputLine.Text = firstNum.ToString();
                        break;
                    }
                case '-':
                    {
                        secondNum = Convert.ToDouble(inputAndOutputLine.Text);
                        result = firstNum - secondNum;
                        firstNum = result;
                        inputAndOutputLine.Text = firstNum.ToString();
                        break;
                    }
                case '*':
                    {
                        secondNum = Convert.ToDouble(inputAndOutputLine.Text);
                        result = firstNum * secondNum;
                        firstNum = result;
                        inputAndOutputLine.Text = firstNum.ToString();
                        break;
                    }
                case '/':
                    {
                        secondNum = Convert.ToDouble(inputAndOutputLine.Text);
                        if (secondNum == 0)
                        {
                            inputAndOutputLine.Clear();
                            textBox1.Clear();
                            inputAndOutputLine.Text = null;
                            return;
                        }
                        else
                        {
                            result = firstNum / secondNum;
                            firstNum = result;
                            inputAndOutputLine.Text = firstNum.ToString();
                        }
                        break;
                    }
                case '%':
                    {
                        secondNum = Convert.ToDouble(inputAndOutputLine.Text);
                        result = firstNum * secondNum / 100;
                        firstNum = result;
                        inputAndOutputLine.Text = firstNum.ToString();
                        break;
                    }
            }
            isOperationPressedEarly = false;
            EmtyEqual = true;
            textBox1.Clear();
        }

        private void inputNumButton_Click(object sender, EventArgs e)
        {
            inputAndOutputLine.Text += (sender as Button).Text;
            textBox1.Text += (sender as Button).Text;
        }

        double firstNum = 0;
        double secondNum = 0;
        double result = 0;
        char sumbol = ' ';
        bool isOperationPressedEarly = false;
        bool EmtyEqual = false;
        bool EmtyString = false;
        private void inputSymblButton_Click(object sender, EventArgs e)
        {
            EmtyString = false;
            if (inputAndOutputLine.Text.Length == 0)
            {
                return;
            }
            int count = 0;
            if (EmtyEqual)
            {
                textBox1.Text += firstNum;
            }
            if (!isOperationPressedEarly)
            {
                try
                {
                    firstNum = Convert.ToDouble(inputAndOutputLine.Text);
                    inputAndOutputLine.Clear();
                }
                catch
                {
                    inputAndOutputLine.Text = "Не корректный ввод";
                }
                count++;
                sumbol = (sender as Button).Text[0];
                textBox1.Text += sumbol;
            }
            else
            {
                try
                {
                    secondNum = Convert.ToDouble(inputAndOutputLine.Text);
                    inputAndOutputLine.Clear();
                }
                catch
                {
                    inputAndOutputLine.Text = "Не корректный ввод";
                }
                switch (sumbol)
                {
                    case '+':
                        {
                            result = firstNum + secondNum;
                            firstNum = result;
                            textBox1.Clear();
                            textBox1.Text = firstNum.ToString();
                            count++;
                            break;
                        }
                    case '-':
                        {
                            result = firstNum - secondNum;
                            firstNum = result;
                            textBox1.Clear();
                            textBox1.Text = firstNum.ToString();
                            count++;
                            break;
                        }
                    case '*':
                        {
                            result = firstNum * secondNum;
                            firstNum = result;
                            textBox1.Clear();
                            textBox1.Text = firstNum.ToString();
                            count++;
                            break;
                        }
                    case '/':
                        {
                            if (secondNum == 0)
                            {
                                inputAndOutputLine.Clear();
                                textBox1.Clear();
                                inputAndOutputLine.Text = null;
                                return;
                            }
                            else
                            {
                                result = firstNum / secondNum;
                                firstNum = result;
                                textBox1.Clear();
                                textBox1.Text = firstNum.ToString();
                            }
                            count++;
                            break;
                        }
                    case '%':
                        {
                            result = firstNum * secondNum / 100;
                            firstNum = result;
                            textBox1.Clear();
                            textBox1.Text = firstNum.ToString();
                            count++;
                            break;
                        }
                }
                sumbol = (sender as Button).Text[0];
                if (count != 0)
                {
                    textBox1.Text += sumbol;
                    count--;
                }
            }
            isOperationPressedEarly = true;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            firstNum = 0;
            secondNum = 0;
            inputAndOutputLine.Clear();
            textBox1.Clear();
        }

        private void oppositeMeaningButton_Click(object sender, EventArgs e)
        {
            if (inputAndOutputLine.Text != "")
            {
                if (inputAndOutputLine.Text[0] == '-')
                {
                    inputAndOutputLine.Text = inputAndOutputLine.Text.Remove(0, 1);
                }
                else
                {
                    inputAndOutputLine.Text = '-' + inputAndOutputLine.Text;
                }
            }
            if (textBox1.Text != "")
            {
                if (textBox1.Text[0] == '-')
                {
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                }
                else
                {
                    textBox1.Text = '-' + textBox1.Text;
                }
            }
        }

        private void arrowButton_Click(object sender, EventArgs e)
        {
            if (inputAndOutputLine.Text != "")
            {
                inputAndOutputLine.Text = inputAndOutputLine.Text.Remove(inputAndOutputLine.Text.Length - 1, 1);
                if (EmtyEqual)
                {
                    firstNum = Convert.ToDouble(inputAndOutputLine.Text);
                }
            }
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void SqrtButton_Click(object sender, EventArgs e)
        {
            if (inputAndOutputLine.Text.Length == 0)
            {
                return;
            }
            double resultOfSqrt = 0;
            int count = 0;
            try
            {
                firstNum = Convert.ToDouble(inputAndOutputLine.Text);
                count++;
            }
            catch
            {
                inputAndOutputLine.Text = "Нет числа";
            }
            if (firstNum < 0)
            {
                inputAndOutputLine.Clear();
                textBox1.Clear();
                count--;
            }
            else
            {
                resultOfSqrt = Math.Sqrt(firstNum);
                inputAndOutputLine.Text = resultOfSqrt.ToString();
                textBox1.Text = resultOfSqrt.ToString();
                firstNum = resultOfSqrt;
                count--;
            }
        }

        private void DivisedOnOneButton_Click(object sender, EventArgs e)
        {
            if (inputAndOutputLine.Text.Length == 0)
            {
                return;
            }
            double resultDivisedOnOne = 0;
            int count = 0;
            try
            {
                firstNum = Convert.ToDouble(inputAndOutputLine.Text);
                count++;
            }
            catch
            {
                inputAndOutputLine.Text = "Нет числа";
            }
            if (firstNum == 0)
            {
                inputAndOutputLine.Clear();
                inputAndOutputLine.Text += "0";
                count--;
            }
            else
            {
                resultDivisedOnOne = 1 / firstNum;
                inputAndOutputLine.Text = resultDivisedOnOne.ToString();
                textBox1.Text = resultDivisedOnOne.ToString();
                firstNum = resultDivisedOnOne;
                count--;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.MaxLength;
        }

        private void inputAndOutputLine_TextChanged(object sender, EventArgs e)
        {
            inputAndOutputLine.TextAlign = HorizontalAlignment.Right;
            inputAndOutputLine.SelectionStart = textBox1.MaxLength;
        }

        private void buttonSymbolDot_Click(object sender, EventArgs e)
        {
            if(!EmtyString)
            {
                if (inputAndOutputLine.Text.Length > 0)
                {
                    inputAndOutputLine.Text += (sender as Button).Text;
                    textBox1.Text += (sender as Button).Text;
                    EmtyString = true;
                }
            }
            else
            {
                return;
            }
        }
    }
}
