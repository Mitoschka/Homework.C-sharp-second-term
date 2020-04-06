using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analog_Clock
{
    public partial class Form1 : Form
    {
        Bitmap back, hour, minute, dot, second;

        private void dotBox_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void lblSecond_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PrivateFontCollection fontCollection = new PrivateFontCollection();
            fontCollection.AddFontFile("362_LCDNOVA.ttf"); 
            FontFamily family = fontCollection.Families[0];

            lblTime.Font = new Font(family, 15);
            lblDate.Font = new Font(family, 13);
            lblDay.Font = new Font(family, 13);

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
            hourBox.Image = rotateImage(hour, AngleH);


            hourBox.Controls.Add(minuteBox);
            minuteBox.Location = new Point(0, 0);
            minuteBox.Image = rotateImage(minute, AngleM);

            minuteBox.Controls.Add(dotBox);
            dotBox.Location = new Point(0, 0);
            dotBox.Image = dot;


            dotBox.Controls.Add(secondBox);
            secondBox.Location = new Point(0, 0);
            secondBox.Image = rotateImage(second, AngleS);
        }

        public Form1()
        {
            InitializeComponent();

            back = new Bitmap(".\\back.png");
            hour = new Bitmap(".\\hour.png");
            minute = new Bitmap(".\\minute.png");
            dot = new Bitmap(".\\dot.png");
            second = new Bitmap(".\\second.png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Bitmap rotateImage(Bitmap rotateMe, float angle)
        {
            Bitmap rotatedImage = new Bitmap(rotateMe.Width, rotateMe.Height);

            using(Graphics g = Graphics.FromImage(rotatedImage))
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
