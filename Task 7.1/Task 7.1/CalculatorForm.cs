using System;
using System.Linq;
using System.Windows.Forms;

namespace Task_7._1
{
    public partial class CalculatorForm : Form
    {
        private CalculatorLogic calculatorLogic;
        public CalculatorForm()
        {
            InitializeComponent();
            calculatorLogic = new CalculatorLogic();
        }

        public void Operation()
        {
            if (!calculatorLogic.IsOperationPressedEarly)
            {
                calculatorLogic.SecondNum = Convert.ToDouble(inputAndOutputLineOfResult.Text);
                inputAndOutputLineOfResult.Clear();
            }
            calculatorLogic.Operation();
            inputAndOutputLineOfResult.Text = calculatorLogic.FirstNum.ToString();
        }
        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if (inputAndOutputLineOfResult.Text.Length == 0)
            {
                return;
            }
            calculatorLogic.SecondNum = Convert.ToDouble(inputAndOutputLineOfResult.Text);
            calculatorLogic.EqualButtonPressed();
            inputAndOutputLineOfResult.Text = calculatorLogic.FirstNum.ToString();
            inputAndOutputLineOfOperation.Clear();
            calculatorLogic.IsDelete = false;
        }

        public void inputNumButton_Click(object sender, EventArgs e)
        {
            if(calculatorLogic.IsEqualPressed)
            {
                if(!calculatorLogic.IsDelete)
                {
                    inputAndOutputLineOfResult.Clear();
                    calculatorLogic.IsDelete = true;
                }
                inputAndOutputLineOfResult.Text += (sender as Button).Text;
                return;
            }
            inputAndOutputLineOfResult.Text += (sender as Button).Text;
            inputAndOutputLineOfOperation.Text += (sender as Button).Text;
        }

        private void inputSymbolButton_Click(object sender, EventArgs e)
        {
            calculatorLogic.IsContainDot = false;
            if (inputAndOutputLineOfResult.Text.Length == 0 && inputAndOutputLineOfOperation.Text.Length == 0)
            {
                return;
            }
            if (calculatorLogic.IsEqualPressed)
            {
                calculatorLogic.FirstNum = Convert.ToDouble(inputAndOutputLineOfResult.Text);
                inputAndOutputLineOfOperation.Text += calculatorLogic.FirstNum;
                calculatorLogic.IsEqualPressed = false;
            }
            if (!calculatorLogic.IsOperationPressedEarly)
            {
                try
                {
                    calculatorLogic.FirstNum = Convert.ToDouble(inputAndOutputLineOfResult.Text);
                    inputAndOutputLineOfResult.Clear();
                }
                catch
                {
                    inputAndOutputLineOfResult.Text = "Не корректный ввод";
                }
                calculatorLogic.Symbol = (sender as Button).Text[0];
                inputAndOutputLineOfOperation.Text += calculatorLogic.Symbol;
            }
            else
            {
                try
                {
                    calculatorLogic.SecondNum = Convert.ToDouble(inputAndOutputLineOfResult.Text);
                    inputAndOutputLineOfResult.Clear();
                }
                catch
                {
                    inputAndOutputLineOfResult.Text = "Не корректный ввод";
                }
                Operation();
                calculatorLogic.Symbol = (sender as Button).Text[0];
                inputAndOutputLineOfResult.Clear();
                inputAndOutputLineOfOperation.Text = calculatorLogic.FirstNum.ToString();
                inputAndOutputLineOfOperation.Text += calculatorLogic.Symbol;
            }
            calculatorLogic.IsOperationPressedEarly = true;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            calculatorLogic.Remove();
            inputAndOutputLineOfResult.Clear();
            inputAndOutputLineOfOperation.Clear();
            calculatorLogic.IsDelete = false;
        }

        private void oppositeMeaningButton_Click(object sender, EventArgs e)
        {
            if (inputAndOutputLineOfResult.Text != "")
            {
                if (inputAndOutputLineOfResult.Text[0] == '-')
                {
                    inputAndOutputLineOfResult.Text = inputAndOutputLineOfResult.Text.Remove(0, 1);
                }
                else
                {
                    inputAndOutputLineOfResult.Text = '-' + inputAndOutputLineOfResult.Text;
                }
            }
            if (inputAndOutputLineOfOperation.Text != "")
            {
                if (inputAndOutputLineOfOperation.Text[0] == '-')
                {
                    inputAndOutputLineOfOperation.Text = inputAndOutputLineOfOperation.Text.Remove(0, 1);
                }
                else
                {
                    inputAndOutputLineOfOperation.Text = '-' + inputAndOutputLineOfOperation.Text;
                }
            }
        }

        private void arrowButton_Click(object sender, EventArgs e)
        {
            if (inputAndOutputLineOfResult.Text != "")
            {
                if (inputAndOutputLineOfOperation.Text != "")
                {
                    inputAndOutputLineOfOperation.Text = inputAndOutputLineOfOperation.Text.Remove(inputAndOutputLineOfOperation.Text.Length - 1, 1);
                }
                inputAndOutputLineOfResult.Text = inputAndOutputLineOfResult.Text.Remove(inputAndOutputLineOfResult.Text.Length - 1, 1);
                if (calculatorLogic.IsEqualPressed)
                {
                    calculatorLogic.FirstNum = Convert.ToDouble(inputAndOutputLineOfResult.Text);
                }
                else
                {
                    return;
                }
            }
            if (inputAndOutputLineOfOperation.Text != "")
            {
                inputAndOutputLineOfOperation.Text = inputAndOutputLineOfOperation.Text.Remove(inputAndOutputLineOfOperation.Text.Length - 1, 1);
            }
            if (!inputAndOutputLineOfResult.Text.Contains(","))
            {
                calculatorLogic.IsContainDot = false;
            }
            if (!inputAndOutputLineOfResult.Text.Contains(calculatorLogic.Symbol))
            {
                calculatorLogic.Symbol = ' ';
            }
        }

        private void SqrtButton_Click(object sender, EventArgs e)
        {
            if (inputAndOutputLineOfResult.Text.Length == 0)
            {
                return;
            }
            double resultOfSqrt = 0;
            int count = 0;
            try
            {
                calculatorLogic.FirstNum = Convert.ToDouble(inputAndOutputLineOfResult.Text);
                count++;
            }
            catch
            {
                inputAndOutputLineOfResult.Text = "Нет числа";
            }
            if (calculatorLogic.FirstNum < 0)
            {
                inputAndOutputLineOfResult.Clear();
                inputAndOutputLineOfOperation.Clear();
                count--;
            }
            else
            {
                calculatorLogic.SqrtMath(resultOfSqrt);
                inputAndOutputLineOfResult.Text = calculatorLogic.FirstNum.ToString();
                inputAndOutputLineOfOperation.Text = calculatorLogic.FirstNum.ToString();
                count--;
            }
        }

        private void DivisedOnOneButton_Click(object sender, EventArgs e)
        {
            if (inputAndOutputLineOfResult.Text.Length == 0)
            {
                return;
            }
            double resultDivisedOnOne = 0;
            int count = 0;
            try
            {
                calculatorLogic.FirstNum = Convert.ToDouble(inputAndOutputLineOfResult.Text);
                count++;
            }
            catch
            {
                inputAndOutputLineOfResult.Text = "Нет числа";
            }
            if (calculatorLogic.FirstNum == 0)
            {
                inputAndOutputLineOfResult.Clear();
                inputAndOutputLineOfResult.Text += "0";
                count--;
            }
            else
            {
                calculatorLogic.DivisedOnOne(resultDivisedOnOne);
                inputAndOutputLineOfResult.Text = calculatorLogic.FirstNum.ToString();
                inputAndOutputLineOfOperation.Text = calculatorLogic.FirstNum.ToString();
                count--;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            inputAndOutputLineOfOperation.TextAlign = HorizontalAlignment.Right;
            inputAndOutputLineOfOperation.Focus();
            inputAndOutputLineOfOperation.SelectionStart = inputAndOutputLineOfOperation.MaxLength;
        }

        private void inputAndOutputLine_TextChanged(object sender, EventArgs e)
        {
            inputAndOutputLineOfResult.TextAlign = HorizontalAlignment.Right;
            inputAndOutputLineOfResult.SelectionStart = inputAndOutputLineOfOperation.MaxLength;
        }

        private void buttonSymbolDot_Click(object sender, EventArgs e)
        {
            if (!inputAndOutputLineOfResult.Text.Contains(","))
            {
                if (inputAndOutputLineOfResult.Text.Length > 0)
                {
                    inputAndOutputLineOfResult.Text += (sender as Button).Text;
                    inputAndOutputLineOfOperation.Text += (sender as Button).Text;
                    calculatorLogic.IsContainDot = true;
                }
            }
        }
    }
}
