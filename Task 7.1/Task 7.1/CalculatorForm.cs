using System;
using System.Linq;
using System.Windows.Forms;

namespace Task_7._1
{
    public partial class CalculatorForm : Form
    {
        CalculatorLogic calculatorLogic;
        public CalculatorForm()
        {
            InitializeComponent();
            calculatorLogic = new CalculatorLogic();
        }

        public void Operation()
        {
            if (!calculatorLogic.IsOperationPressedEarly)
            {
                calculatorLogic.SecondNum = Convert.ToDouble(inputAndOutputLine.Text);
                inputAndOutputLine.Clear();
            }
            calculatorLogic.Operation();
            inputAndOutputLine.Text = calculatorLogic.FirstNum.ToString();
        }
        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if (inputAndOutputLine.Text.Length == 0)
            {
                return;
            }
            calculatorLogic.SecondNum = Convert.ToDouble(inputAndOutputLine.Text);
            calculatorLogic.EqualButtonPressed();
            inputAndOutputLine.Text = calculatorLogic.FirstNum.ToString();
            textBox1.Clear();
        }

        public void inputNumButton_Click(object sender, EventArgs e)
        {
            inputAndOutputLine.Text += (sender as Button).Text;
            textBox1.Text += (sender as Button).Text;
        }

        private void inputSumbolButton_Click(object sender, EventArgs e)
        {
            calculatorLogic.IsContainDot = false;
            if (inputAndOutputLine.Text.Length == 0 && textBox1.Text.Length == 0)
            {
                return;
            }
            if (calculatorLogic.IsEqualPressed)
            {
                textBox1.Text += calculatorLogic.FirstNum;
            }
            if (!calculatorLogic.IsOperationPressedEarly)
            {
                try
                {
                    calculatorLogic.FirstNum = Convert.ToDouble(inputAndOutputLine.Text);
                    inputAndOutputLine.Clear();
                }
                catch
                {
                    inputAndOutputLine.Text = "Не корректный ввод";
                }
                calculatorLogic.Sumbol = (sender as Button).Text[0];
                textBox1.Text += calculatorLogic.Sumbol;
            }
            else
            {
                try
                {
                    calculatorLogic.SecondNum = Convert.ToDouble(inputAndOutputLine.Text);
                    inputAndOutputLine.Clear();
                }
                catch
                {
                    inputAndOutputLine.Text = "Не корректный ввод";
                }
                Operation();
                calculatorLogic.Sumbol = (sender as Button).Text[0];
                inputAndOutputLine.Clear();
                textBox1.Text = calculatorLogic.FirstNum.ToString();
                textBox1.Text += calculatorLogic.Sumbol;
            }
            calculatorLogic.IsOperationPressedEarly = true;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            calculatorLogic.Remove();
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
                if (textBox1.Text != "")
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }
                inputAndOutputLine.Text = inputAndOutputLine.Text.Remove(inputAndOutputLine.Text.Length - 1, 1);
                if (calculatorLogic.IsEqualPressed)
                {
                    calculatorLogic.FirstNum = Convert.ToDouble(inputAndOutputLine.Text);
                }
                else
                {
                    return;
                }
            }
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (!inputAndOutputLine.Text.Contains(","))
            {
                calculatorLogic.IsContainDot = false;
            }
            if (!inputAndOutputLine.Text.Contains(calculatorLogic.Sumbol))
            {
                calculatorLogic.Sumbol = ' ';
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
                calculatorLogic.FirstNum = Convert.ToDouble(inputAndOutputLine.Text);
                count++;
            }
            catch
            {
                inputAndOutputLine.Text = "Нет числа";
            }
            if (calculatorLogic.FirstNum < 0)
            {
                inputAndOutputLine.Clear();
                textBox1.Clear();
                count--;
            }
            else
            {
                calculatorLogic.SqrtMath(resultOfSqrt);
                inputAndOutputLine.Text = calculatorLogic.FirstNum.ToString();
                textBox1.Text = calculatorLogic.FirstNum.ToString();
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
                calculatorLogic.FirstNum = Convert.ToDouble(inputAndOutputLine.Text);
                count++;
            }
            catch
            {
                inputAndOutputLine.Text = "Нет числа";
            }
            if (calculatorLogic.FirstNum == 0)
            {
                inputAndOutputLine.Clear();
                inputAndOutputLine.Text += "0";
                count--;
            }
            else
            {
                calculatorLogic.DivisedOnOne(resultDivisedOnOne);
                inputAndOutputLine.Text = calculatorLogic.FirstNum.ToString();
                textBox1.Text = calculatorLogic.FirstNum.ToString();
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
            if (!inputAndOutputLine.Text.Contains(","))
            {
                if (inputAndOutputLine.Text.Length > 0)
                {
                    inputAndOutputLine.Text += (sender as Button).Text;
                    textBox1.Text += (sender as Button).Text;
                    calculatorLogic.IsContainDot = true;
                }
            }
            else
            {
                return;
            }
        }
    }
}
