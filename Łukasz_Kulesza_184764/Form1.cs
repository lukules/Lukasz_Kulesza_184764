using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Łukasz_Kulesza_184764
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<PictureBox> circles = new List<PictureBox>();
        int counter = 0;
        int time = 60;

        public Form1()
        {
            InitializeComponent();
        }

        public void DrawPictureBox()
        {
            PictureBox newCircle = new PictureBox();
            int size = random.Next(30, 60);
            newCircle.Height = size;
            newCircle.Width = size;

            int color = random.Next(1, 5);
            if(color == 1)
                newCircle.BackColor = Color.Red;
            if(color == 2)
                newCircle.BackColor = Color.Blue;
            if(color == 3)
                newCircle.BackColor = Color.Green;
            if(color == 4)
                newCircle.BackColor = Color.Black;

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, newCircle.Width - 3, newCircle.Height - 3);
            Region rg = new Region(gp);
            newCircle.Region = rg;

            int x = random.Next(10, this.ClientSize.Width - newCircle.Width);
            int y = random.Next(10, this.ClientSize.Height - newCircle.Height);

            newCircle.Location = new Point(x, y);
            newCircle.Click += NewCircle_Click;

            circles.Add(newCircle);
            this.Controls.Add(newCircle);



        }

        private void NewCircle_Click(object sender, EventArgs e)
        {
            PictureBox temCircle = sender as PictureBox;
            counter++;
            circles.Remove(temCircle);
            this.Controls.Remove(temCircle);
            Counter.Text = "Liczba poprawnych kliknięć: " + counter;

        }

        private void TimerEvent(object sender, EventArgs e)
        {
            DrawPictureBox();

            Counter.Text = "Liczba poprawnych kliknięć: " + counter;

        }

        private void RemainingTime_Tick(object sender, EventArgs e)
        {
            time--;
            if(time == 0)
            {
                RemainingTime.Stop();
            }

            RemainingTimeLabel.Text = "Pozostały czas: " + time + "s";
        }
    }
}
