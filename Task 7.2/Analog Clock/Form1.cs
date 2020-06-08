using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace AnalogClock
{
    public partial class ClockForm : Form
    {
        private int count = 0;
        private Bitmap back;
        private Bitmap hour;
        private Bitmap minute;
        private Bitmap dot;
        private Bitmap second;

        private void button1_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                back = Analog_Clock.Properties.Resources.oldBack;
                count = 1;
                return;
            }
            if (count == 1)
            {
                back = Analog_Clock.Properties.Resources.back;
                count = 2;
                return;
            }
            if (count == 2)
            {
                back = Analog_Clock.Properties.Resources.newBack;
                count = 0;
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");

            DateTime Now = DateTime.Now;
            int Hour = Now.Hour;
            int Minute = Now.Minute;
            int Second = Now.Second;

            Single AngleS = Second * 6;
            Single AngleM = Minute * 6 + AngleS / 60;
            Single AngleH = Hour * 30 + AngleM / 12;

            backBox.Image = back;

            backBox.Controls.Add(hourBox);
            hourBox.Location = new Point(0, 0);
            hourBox.Image = RotateImage(hour, AngleH);


            hourBox.Controls.Add(minuteBox);
            minuteBox.Location = new Point(0, 0);
            minuteBox.Image = RotateImage(minute, AngleM);

            minuteBox.Controls.Add(dotBox);
            dotBox.Location = new Point(0, 0);
            dotBox.Image = dot;


            dotBox.Controls.Add(secondBox);
            secondBox.Location = new Point(0, 0);
            secondBox.Image = RotateImage(second, AngleS);
        }

        public ClockForm()
        {
            InitializeComponent();

            back = Analog_Clock.Properties.Resources.newBack;
            hour = Analog_Clock.Properties.Resources.hour;
            minute = Analog_Clock.Properties.Resources.minute;
            dot = Analog_Clock.Properties.Resources.dot;
            second = Analog_Clock.Properties.Resources.second;
        }

        private Bitmap RotateImage(Bitmap rotateMe, float angle)
        {
            var rotatedImage = new Bitmap(rotateMe.Width, rotateMe.Height);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(rotateMe.Width / 2, rotateMe.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-rotateMe.Width / 2, -rotateMe.Height / 2);
                g.DrawImage(rotateMe, new Point(0, 0));
            }

            return rotatedImage;
        }
    }
}
