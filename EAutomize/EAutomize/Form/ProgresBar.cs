using System;
using System.Drawing;
using System.Windows.Forms;

namespace EAutomize.Form
{
    public partial class ProgresBar : System.Windows.Forms.Form
    {
        public ProgresBar()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) // генерация ленты
        {
            Progress.Value += 2;
            if(Progress.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                Home home = new Home();
                home.Show();
            }
        }

        Point lastPoint;
        private void ProgresBar_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ProgresBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void logo_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void logo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

    }
}
