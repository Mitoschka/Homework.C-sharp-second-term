using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// Пространство имён
/// </summary>
namespace FindPair
{
    public partial class GameForm : Form
    {
        private Random random = new Random();

        private List<int> numbers;

        private Label firstClicked = null;

        private Label secondClicked = null;

        /// <summary>
        /// Инициализация и заполнение формы
        /// </summary>
        public GameForm(int sizeOfTable)
        {
            numbers = new List<int>();
            for (int i = 0; i != sizeOfTable * sizeOfTable; ++i)
            {
                numbers.Add(i / 2);
            }

            InitializeComponent(sizeOfTable);
            FillLables();
        }

        /// <summary>
        /// Сопоставить каждой кнопке определенное число.
        /// </summary>
        private void FillLables()
        {
            foreach (Control control in tableLayoutPanel.Controls)
            {
                Label label = control as Label;
                if (label != null)
                {
                    int randomNumber = random.Next(numbers.Count);
                    label.Text = numbers[randomNumber].ToString();
                    label.ForeColor = label.BackColor;
                    numbers.RemoveAt(randomNumber);
                }
            }
        }

        /// <summary>
        /// Обрабатывает нажатие на какую-либо кнопку в игре.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickOnLabel(object sender, EventArgs e)
        {
            if (timerForStepOfPlayer.Enabled == true)
            {
                return;
            }

            Label clickedLabel = sender as Label;

            if (secondClicked != null)
            {
                return;
            }

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                {
                    return;
                }

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                CheckIfPlayerWon();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                timerForStepOfPlayer.Start();
            }
        }

        /// <summary>
        /// Сбрасывает открытые кнопки игрока через некоторое время, если они оказались разными.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tickOfTheTimer(object sender, EventArgs e)
        {
            timerForStepOfPlayer.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        /// <summary>
        /// Проверка, открыты ли все пары.
        /// </summary>
        private void CheckIfPlayerWon()
        {
            foreach (Control control in tableLayoutPanel.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            MessageBox.Show("Все пары найдены!", "Игра завершена.");
            Close();
        }
    }
}
