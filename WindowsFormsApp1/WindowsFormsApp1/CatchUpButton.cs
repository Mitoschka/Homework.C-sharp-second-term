using System;
using System.Windows.Forms;


namespace RunningButton
{
    public partial class CatchUpButton : Form
    {
        private Random randomNumber = new Random();
        public CatchUpButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, который меняет расположение кнопки, если ее касается курсор.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CursorTouchesRunawayButton(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            int cursorX = Cursor.Position.X;
            int cursorY = Cursor.Position.Y;
            int newButtonX = cursorX;
            int newButtonY = cursorY;
            while (cursorX >= newButtonX && cursorX <= newButtonX + button.Width && cursorY >= newButtonY && cursorY <= newButtonY + button.Height)
            {
                newButtonX = randomNumber.Next(0, this.ClientSize.Width - button.Width);
                newButtonY = randomNumber.Next(0, this.ClientSize.Height - button.Height);
            }
            button.Location = new System.Drawing.Point(newButtonX, newButtonY);
        }

        /// <summary>
        /// Метод, который открывает messageBox, если кнопка была нажата.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRunawayButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Fail.");
        }
    }
}
