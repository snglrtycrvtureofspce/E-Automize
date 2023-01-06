using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EAutomize.Form
{
    public partial class SystemSP : System.Windows.Forms.Form
    {
        public SystemSP()
        {
            InitializeComponent();
            //gunaPanel19.Height = 34;
            //gunaPanel17.Height = 34;
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void SystemSP_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void SystemSP_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void SystemSP_Load(object sender, EventArgs e)
        {
            const string path = "Help.txt";
            richTextBox1.ReadOnly = true;
            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.Text = File.ReadAllText(path);
        }

        //private void gunaPictureBox10_Click(object sender, EventArgs e)
        //{
        //    if(gunaPanel19.Height == 34) gunaPanel19.Height = 128;
        //    else gunaPanel19.Height = 34;
        //}

        //private void gunaPictureBox9_Click(object sender, EventArgs e)
        //{
        //    if (gunaPanel17.Height == 34) gunaPanel17.Height = 93;
        //    else gunaPanel17.Height = 34;
        //}
    }
}
