using System;
using System.Windows.Forms;
using EAutomize.Form;

namespace EAutomize.Control
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }


        private void btnSignIN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home.Instance.Hide();
            SIGNin sIGNin = new SIGNin();
            sIGNin.Show();
        }

        private void btnSignUP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home.Instance.Hide();
            SIGNup sIGNup = new SIGNup();
            sIGNup.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
